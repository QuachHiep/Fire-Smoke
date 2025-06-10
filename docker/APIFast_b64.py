from fastapi import FastAPI, File, UploadFile
from fastapi.responses import JSONResponse
from pydantic import BaseModel
from ultralytics import YOLO
import time
import base64
from PIL import Image
from io import BytesIO
from typing import List

# Tạo ứng dụng FastAPI
app = FastAPI(name = "fire")

# Load mô hình YOLO
model = YOLO("best.pt")
model.to(device="cuda")  # Chuyển mô hình sang GPU nếu có

# Mô hình dữ liệu nhận ảnh Base64 từ C#
class ImageData(BaseModel):
    image: str  # Chuỗi Base64 của ảnh
# Mô hình dữ liệu đầu ra
class DetectionResponse(BaseModel):
    label: str
    x1: float
    y1: float
    x2: float
    y2: float
    score: float

@app.post("/predict", response_model=List[DetectionResponse])
async def predict(data: ImageData):
    try:
        # Đọc ảnh từ file
        start_time = time.perf_counter()
        img_data = base64.b64decode(data.image)
        img = Image.open(BytesIO(img_data))
        print(f"Image size: {img.size}")
        
        # Dự đoán bằng YOLO
        results = list(model(img, stream=True, imgsz=1280))  # Dự đoán với kích thước 1280 và ngưỡng confidence 0.5
        #results = model.predict()
        
        detections = []

        # Lọc các kết quả phát hiện
        for result in results:
            box = result.boxes
            box = box.data
            if box.nelement() > 0:
                boxdata = box.cpu().numpy()
                for single_box in boxdata:
                    x1, y1, x2, y2, score, predict_class = single_box
                    if predict_class == 0 and score > 0:  # Nếu là lửa
                        detections.append({
                            "label": "FIRE",
                            "x1": round(float(x1), 2),
                            "y1": round(float(y1), 2),
                            "x2": round(float(x2), 2),
                            "y2": round(float(y2), 2),
                            "score": round(float(score), 2)
                        })
                    elif predict_class == 1 and score > 0:  # Nếu là khói
                        detections.append({
                            "label": "SMOKE",
                            "x1": round(float(x1), 2),
                            "y1": round(float(y1), 2),
                            "x2": round(float(x2), 2),
                            "y2": round(float(y2), 2),
                            "score": round(float(score), 2)
                        })
        print(f"Detections: {detections}")

        # Trả về kết quả dưới dạng JSON
        end_time = time.perf_counter()
        elapsed_time_ms = (end_time - start_time) * 1000  # Tính bằng mili giây
        print(f"Thời gian chạy là: {elapsed_time_ms:.4f} ms")
        return detections
    except Exception as e:
        # Xử lý lỗi và trả về thông báo lỗi dưới dạng JSON
        return JSONResponse(status_code=400, content={"error": str(e)})

if __name__ == "__main__":
    import uvicorn
    uvicorn.run("APIFast_b64:app", host="0.0.0.0", port=8000, workers = 4, reload = True)  # Đảm bảo server đang lắng nghe ở cổng 8081
