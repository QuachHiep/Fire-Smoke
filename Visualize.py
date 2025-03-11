import json
import cv2


if __name__ == '__main__':
    image_path = r"E:\hiepqn\Data_Fire\Val\Image\flame\Educational and research facilities_Business facilities\0929\JPG\0929_FL_ERBF_00001.jpg"
    label_path = r"E:\hiepqn\Data_Fire\Val\Label\flame\Educational and research facilities_Business facilities\0929\JSON\0929_FL_ERBF_00001.json"

    image = cv2.imread(image_path)

    with open(label_path, "r") as json_file:
        json_data = json.load(json_file)
    width = json_data["image"]["width"]
    height = json_data["image"]["height"]

    current = [{"bbox": obj["bbox"], "categories_id": obj["categories_id"]} for obj in
               json_data["annotations"]]
    for obj in current:
        xmin, ymin, w, h = obj["bbox"]

    cv2.rectangle(image, (int(xmin), int(ymin)), (int(xmin + w), int(ymin + h)), (255, 0, 0), 2)
    cv2.imshow("test", image)
    cv2.waitKey(0)
