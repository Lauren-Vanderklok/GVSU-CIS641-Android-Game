# GVSU-CIS641-Android-Game

## How to commit to this repo!

### before you start working!

1. Make a new branch from the 'develop' branch. To do this, navigate to the 'develop' branch from the drop down in the code tab. Once youre there, from that same drop down, start typeing what you want to name your branch. A option to create a branch of that name from develop should appear. Click that option. 
2. Open your command line. Navigate to where you have cloned the project. 
3. Run the command 'git fetch' this command gets changes from the remote repository (online) but does not overwrite anything you have on your local machine. This command should print a list of newly created branches, the one you created in step one should be on there. 
4. Run 'git checkout <name of your new branch>' without the <> . You are now on your new branch

### When you are ready to commit!
  
1. Save your work in Unity. File > Save. You dont need to click Save Project. Save includes Save Project 
2. Close Unity. You will not be able to run the next command if unity is open. 
3. Run 'git add .' this tells git you want to commit everything that has changed since your last commit.
4. Run 'git commit -m "message you want to show up on github"' don't forget to add the "quotation" marks
5. Run 'git push' this uploads your commit to the remote (online) repository
6. Create a pull request. This tells me you are done, and then I can merge it into the develop branch. We do this to prevent people overwritting other people's changes and prevent commits with problems in them from getting added to other people's code.
7. To create a pull request, go to the pull requests tab on github. Click 'Create Pull Request' button. At dropdowns at the top of the page, change the base repository from gvsu-cis641/base to Lauren-Vanderklok/GVSU-CIS641-Android-Game. In the next drop down, change the base branch to develop, and change the dropdown that says 'compare: ' from master to whatever you named your branch.
8. Mark your story as complete in the google excel document. make sure you mark the date for our required burndown chart



Project description (~1 paragraph)

## Team Members and Roles

* [Lauren Vanderklok](https://github.com/Lauren-Vanderklok/CIS641-HW2-Vanderklok)
* [Trey Smith](https://github.com/Treybuchet116/it-CIS641-HW2-Smith.git)
* [Anna Kakarala](https://github.com/akakarala/641CIS-hw2-Kakarala)
* [Sathya Kiran Gandavarapu](https://github.com/sathya-rgv/CIS641-HW2-Gandavarapu)

## Prerequisites

* Install Unity Hub, this is a launcher for managing different versions and extensions for Unity. When you go to work on the project, open it with Unity Hub
* Install Unity version 2020.3.19f1 through Unity Hub. To do this open Unity Hub, go to 'Installs' on the side, and click 'ADD' select Unity 2020.3.19f1 (LTS) (note: unity has released a new LTS (long term support) version since we started, so v2020.3.19f1 may not be available anymore. In this case install Unity 2020.3.20f1 (LTS))
* Add Android bulid support to your Unity install. If you have android on your unity install, a small android logo will show up on the bottom of your install on Unity Hub. If you dont see this, click the 3 dots on the top of your unity install, click 'Add Modules' and check 'Android Build Support'
* Install Visual Studio, this is your IDE, the app that we code C# in
* Install git, make sure you can access it from your command line. 
* Install Unity Remote 5 from the play store on your testing Android device this [youtube video](https://www.youtube.com/watch?v=iCXwaehzRFQ) will help you get started. 


## Run Instructions
