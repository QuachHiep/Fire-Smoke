import cv2
from io import BytesIO
import numpy as np
from flask import Flask, request, jsonify
from ultralytics import  YOLO

app = Flask(__name__)
model = YOLO(r"D:\DeepLearning\Working\Fire_project\Train\ver2\train_flame_smoke_n\weights\best.pt")
model.to(device = "cuda")

#model = YOLO("/src/best.pt")
@app.route('/predict', methods=['POST'])

def predict():
    try:
        file = request.files['file']
        #print(f"Received file: {file.filename}")

        if file and file.filename.lower().endswith('.jpg'):
            file_bytes = np.frombuffer(file.read(), dtype = np.uint8)
            image = cv2.imdecode(file_bytes, cv2.IMREAD_COLOR)
            results = list(model(image, stream=True))
            detections = []
            for result in results:
                box = result.boxes
                box = box.data
                if box.nelement() > 0:
                    boxdata = box.cpu().numpy()
                    for single_box in boxdata:
                        x1 = single_box[0]
                        y1 = single_box[1]
                        x2 = single_box[2]
                        y2 = single_box[3]
                        score = single_box[4]
                        predict_class = single_box[5]
                        if predict_class == 0:
                            if score > 0.3:
                                detections.append({
                                            "label": "FIRE",
                                            "x1": round(float(x1), 2),
                                            "y1": round(float(y1), 2),
                                            "x2": round(float(x2), 2),
                                            "y2": round(float(y2), 2),
                                            "score": round(float(score), 2)
                                        })
                        elif predict_class == 1:
                            if score > 0.3:
                                detections.append({
                                            "label": "SMOKE",
                                            "x1": round(float(x1), 2),
                                            "y1": round(float(y1), 2),
                                            "x2": round(float(x2), 2),
                                            "y2": round(float(y2), 2),
                                            "score": round(float(score), 2)
                                        })
            return jsonify({"detections": detections})
    except Exception as e:
        return jsonify({"error": str(e)})

if __name__ == "__main__":
    app.run(host="0.0.0.0", port=5000,debug=True, threaded=True)
