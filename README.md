# Camera-app
 

### App allows the user to take a picture and view them in a Gallery. There is also a delete toggle button that allows the user to delete any pictures in the gallery and the order of the other photos will be presereved. Photos are automatically uploaded to the Firebase Cloud storage, and when photos are deleted in the cloud storage as well

# **NOTE**
### There is one file missing from this project because the file size excedes the 100MB limit. File path is: Assets/Firebase/Plugins/x86_64. Name of the file is: FirebaseCppApp-6_15_2.so . I would recommend going to the firebase website and follow the guide to download the Firebase folder.

# Limitations
### 1. The App and storage can only store 9 Pictures as of now
### 1. After a picture is taken user must wait 3 seconds before taking another picture or else the picture will be uploaded to the storage, but not displayed in the gallery
### 1. Pictures that are in storage when the app is closed will not be displayed when the user renters the app. No database is set up for it
### 1. App is only compatible with Androids
