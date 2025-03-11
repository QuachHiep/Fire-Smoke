import json
import cv2
import os
from pprint import pprint
import glob
import time
import shutil


def filter_image(filter_paths):
    json_filter = []

    for index,filter_path in enumerate(filter_paths):
        if index % 120 == 0:
            file_name = os.path.basename(filter_path)
            file_name = file_name.replace(".json","")

            with open(filter_path, "r") as json_file:
                json_data = json.load(json_file)
            annotations_categories = {obj["categories_id"] for obj in json_data["annotations"]}
            if not json_data["annotations"]:
                continue
            if annotations_categories == {1,2}:
                continue
            json_filter.append(file_name)
    return json_filter

def pre_image(image_path):
    image_path = image_names[image_path]
    file_name = os.path.basename(image_path)
    shutil.copy(image_path, os.path.join(output_path, "images", "{}".format(file_name)))

def write_label(label_path):
    json_path = json_names[label_path]
    file_name = os.path.basename(json_path)
    file_name = file_name.replace(".json", "")

    with open(json_path, 'r') as json_file:
        json_data = json.load(json_file)
    width = json_data["image"]["width"]
    height = json_data["image"]["height"]

    current = [{"bbox": obj["bbox"], "categories_id": obj["categories_id"]} for obj in
               json_data["annotations"]]

    with open(os.path.join(output_path, "labels", "{}.txt".format(file_name)), "w") as f:
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
                category = 1
            f.write("{} {:06f} {:06f} {:06f} {:06f}\n".format(category, xmin + w / 2, ymin + h / 2, w, h))


if __name__ == '__main__':
    root_path = r"E:\hiepqn\Data_Fire\Train"
    output_path = "Datatest/Train_smoke"

    if not os.path.isdir(output_path):
        os.makedirs(output_path)
        os.makedirs(os.path.join(output_path, "images"))
        os.makedirs(os.path.join(output_path, "labels"))

    counter = 0
    image_files = list(glob.iglob(f"{root_path}/Image/smoke/**/*.jpg", recursive = True))
    json_files = list(glob.iglob(f"{root_path}/Label/smoke/**/*.json", recursive = True))
    image_names = {os.path.splitext(os.path.basename(f))[0]: f for f in image_files}
    json_names = {os.path.splitext(os.path.basename(f))[0]: f for f in json_files}
    common_names = set(image_names.keys()) & set(json_names.keys())
    pprint(f"Matched Images: {len(common_names)}")

    # Get Image Filter
    filters = [f for f in filter_image(json_files) if f]
    filter_names = set(image_names.keys()) & set(filters)
    pprint(f"Matched Filter Image: {len(filter_names)}")
    for i, fl in enumerate(sorted(filter_names)):
        # if counter >= 500:
        #     break
        counter += 1
        pre_image(fl)
        write_label(fl)
        pprint(counter)
