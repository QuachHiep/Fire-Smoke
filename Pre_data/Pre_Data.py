import json
import cv2
import os
from pprint import pprint
import glob
import time
import shutil

if __name__ == '__main__':
    root_path = r"E:\hiepqn\Data_Fire\Train"
    output_path = "Datatest/Train"

    if not os.path.isdir(output_path):
        os.makedirs(output_path)
        os.makedirs(os.path.join(output_path, "images"))
        os.makedirs(os.path.join(output_path, "labels"))
    frames_per_video = 360
    counter = 0
    image_files = list(glob.iglob(f"{root_path}/Image/flame/**/*.jpg", recursive = True))
    json_files = list(glob.iglob(f"{root_path}/Label/flame/**/*.json", recursive = True))
    image_names = {os.path.splitext(os.path.basename(f))[0]: f for f in image_files}
    json_names = {os.path.splitext(os.path.basename(f))[0]: f for f in json_files}
    common_names = set(image_names.keys()) & set(json_names.keys())
    pprint(f"Matched Images: {len(common_names)}")

    for i, fl in enumerate(sorted(common_names)):
        if i % 120 == 0:
            #Get Json
            json_path = json_names[fl]
            with open(json_path, "r") as json_file:
                json_data = json.load(json_file)
            width = json_data["image"]["width"]
            height = json_data["image"]["height"]
            if not json_data["annotations"]:
                continue
            current = [{"bbox": obj["bbox"], "categories_id": obj["categories_id"]} for obj in
                                   json_data["annotations"]]

            # Get Image
            image_path = image_names[fl]
            filename = os.path.basename(image_path)
            filename = filename.replace(".jpg", "")
            counter += 1
            shutil.copy(image_path, os.path.join(output_path, "images", "{}.jpg".format(filename)))

            #Write
            with open(os.path.join(output_path,"labels","{}.txt".format(filename)),"w") as f:
                for obj in current:
                    xmin, ymin, w, h = obj["bbox"]
                    xmin /= width
                    w /= width
                    h /= height
                    ymin /= height

                    # flame la categories_id = 1
                    # smoke la categories_id = 2
                    if obj["categories_id"] == 1:
                        category = 0
                    else:
                        #category = 1
                        continue
                    f.write("{} {:06f} {:06f} {:06f} {:06f}\n".format(category, xmin + w / 2, ymin + h / 2, w, h))
            pprint(counter)

