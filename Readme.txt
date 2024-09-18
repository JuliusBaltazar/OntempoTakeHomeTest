What you need to do:
Design and develop a small application where the user identifies a geographical region by name,
	clicks a Load button, and the names of all the retail branches in that region will be displayed in a grid.
	(The data.json file in this project contains two regions: North Island and South Island. Each has three retail branches.)
 
Design of the UI:
Use the Main.cs windows form that is in this project. Program.cs launches Main.cs.

That Main form needs:
An control for the user to identify a region name (with a caption indicating what the control is for). Choose an appropriate type of control.
A Load button.
A grid for displaying the names of branches belonging to the region.
Bonus: consideration for different users having different screen resolutions.

Behaviour of the app:
The user identifies the region name in the region control.
The user clicks the Load button.			 
The names of the branches belonging to the selected region are displayed in a DataGrid control.

App notes:
There is a Region class and a Branch class in this project. Both have a Name property.
The Region class contains a List<Branch> objects, being the branches belonging to that region.
Load the data from the data.json file into those classes as needed to achieve the solution.
Add and modify classes as you need to.
Write appropriate WinForms code to get that data on screen.
Bonus: write your code as if this app will be released in production.

Email steve@ontempo.co.nz with questions!