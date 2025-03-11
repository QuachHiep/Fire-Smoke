from cleanvision import Imagelab

if __name__ == '__main__':
    imagelab = Imagelab(data_path = "D:/DeepLearning/Working/Fire_project/Datatest/Train_flame/images")
    imagelab.find_issues()
    imagelab.report()