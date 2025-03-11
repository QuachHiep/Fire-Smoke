import cv2
import os
import glob

def Get_frames(root_path):
    output_path = "images_transform"

    video_paths = list(glob.iglob(f"{root_path}/**/*.mp4", recursive = True))
    image_names = list({os.path.splitext(os.path.basename(f))[0]:f for f in video_paths})

    if not os.path.isdir(output_path):
        os.makedirs(output_path)

    for iter, video_path in enumerate(video_paths):
        video = cv2.VideoCapture(video_path)
        if not os.path.isdir("images_transform/{}".format(image_names[iter])):
            os.makedirs(os.path.join(output_path, image_names[iter]))
        print(video_path)
        frame_counter = 0
        while video.isOpened():
            flag, frame = video.read()
            if not flag:
                break
            cv2.imwrite(os.path.join(output_path, image_names[iter], "{}_{}.jpg".format(image_names[iter],frame_counter)), frame)
            print(frame_counter)
            frame_counter += 1

if __name__ == '__main__':
    Get_frames(r"E:\hiepqn\Data_Fire\Test\Hard_Detect")

