import json
import cv2
import os
from pprint import pprint
import glob
import time
import shutil

if __name__ == '__main__':
    root_path = r"D:\DeepLearning\Working\Fire_project\Pre_data\images_transform"
    output_path = "pre_images_transform"

    if not os.path.isdir(output_path):
        os.makedirs(output_path)
        os.makedirs(os.path.join(output_path, "images"))

    counter = 0
    image_files = list(glob.iglob(f"{root_path}/**/*.jpg", recursive = True))
    image_names = {os.path.splitext(os.path.basename(f))[0]: f for f in image_files}

    for i, path in enumerate(image_files):
        if i % 72 == 0:
            filename = os.path.basename(path)
            filename = filename.replace(".jpg", "")
            counter += 1
            shutil.copy(path, os.path.join(output_path, "images", "{}.jpg".format(filename)))
    pprint(counter)


