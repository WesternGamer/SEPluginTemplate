# SEPluginTemplate

This is a template to help you make a Space Engineers Plugin.

## Setup 

1. Download a Zip file copy of this repository. 
![Screenshot (517)](https://user-images.githubusercontent.com/80211714/122436743-12449e00-cf67-11eb-9ea0-d139216f11cc.png)

2. Extract to file to your directory that has your VS projects. Default is: `C:\Users\[Your User]\source\repos`

3. Open the project folder and edit `PostBuild.bat`

4. Change [Project Location] to the directory of your project root folder. It should be`C:\Users\[Your User]\source\repos\SEPluginTemplate` if your project is in the default directory that VS uses.

5. Save the file.

6. Open Visual Studio and click "Open a project or solution"

7. Select `SEPluginTemplate` then  `SEPluginTemplate.sln`

8. The project should open.

6. You are done. If you plan to change the project name, you will need to edit `PostBuild.bat` and change the file name of the file ending in `.dll` to your project name.

## Build your plugin

To build your plugin, just click start and VS will build your plugin, move the plugin to the plugins folder, and start Space Engineers for you. You just need to enable the plugin in the plugins menu if you have SEPluginLoader installed! If you dont have SEPluginLoader installed, then head over to https://github.com/austinvaness/PluginLoader to see how to install it.

If you have issues or need help, feel free to make new issue under the issues tab of this repository!


