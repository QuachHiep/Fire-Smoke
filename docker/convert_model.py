from ultralytics import YOLO
import tensorrt as trt
# Load the YOLO11 model
model = YOLO("best.pt")

# Export the model to TensorRT format
model.export(format="engine")  # creates 'yolo11n.engine'