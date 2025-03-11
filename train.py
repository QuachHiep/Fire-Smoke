from ultralytics import YOLO

try:
    model_path = "/mnt/myhdd/hiepqn/test/yolo11n.pt"
    model = YOLO(model_path)
    model.train(data='/mnt/myhdd/hiepqn/test/mydataset.yaml', epochs=100, batch=16, imgsz=640, optimizer="Adam", device=[0,1])
except Exception as e:
    print('Error'+e)

