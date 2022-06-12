# ProdHelper
A utility designed for Overwatch/General production.

## Documentation

### Settings Utility
Allows you to swap between multiple settings templates located in your Overwatch/Settings folder. To use, either launch the utility to create a new Templates folder or create one yourself and add templates.

The default Settings folder is located at C:\Users\<user>\Documents\Overwatch however you can specify a custom folder while running the application.
![image](https://user-images.githubusercontent.com/16760243/172998522-b8e3df81-df38-4ccb-975a-ce20d5dd4350.png)


### Tally Lights
The tally light system allows your Observers to see information on whether or not they are live, in preview or clear. 

See here for a tutorial: https://www.youtube.com/watch?v=4nAdo8zQvAY or follow the instructions below.

#### Producer/Obs director
 - Launch the Obs Tally Light Utility (Production/OBS Director)
 - Insert your OBS Websocket information in the bottom right and click 'Start'
 - Add a new camera via the 'Add' button in the bottom left, populate the Name and Scene Name in the top right and click 'Update'. The 'Camera Name' field is what your observer with that scene will insert on their end. If you have something like a PIP you are able to add multiple records with the same 'Camera Name' and different scenes.
 - Fill in the Server Settings. The 'Server' field is a valid IP pointing to an instance of the server at TallyLightServer/server.js. This is a simple JavaScript html server that you can setup via NodeJS. The 'Producer' field is a unique name for your production. This is to add another layer of uniqueness and prevents conflicts if two people are using the system with the same camera names. 
 - Click on 'Apply' to validate your server field and click on 'Start' to start sending updates to the server.
 - Updates are only sent when you switch scenes in OBS.

#### Observer
 - Launch the Obs Tally Light Utility (Observer)
 - Fill in the Server Settings. The 'Server' field is a valid IP pointing to an instance of the server at TallyLightServer/server.js. This is a simple JavaScript html server that you can setup via NodeJS. The 'Producer' field needs to match the 'Producer' field on the production/obs director's side. The 'Camera Name' field will be the same as your Camera name on the production/obs director side.
 - Click 'Apply' to validate the server information.
 - Click on 'Open New Window' to open the display. If 'Overlay Application' is unchecked, it will bring up a new square with the status of your feed. If instead 'Overlay Application is checked, you can select the application to overlay on in the 'Select Application' dropdown box.
   - Blue means your camera was not found on the server. Check your camera and production name to make sure it matches that of the producer's side.
   - White means that your camera is clear.
   - Orange means that your camera is on preview.
   - Red means that your camera is live.
 
