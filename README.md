# Shotgun Search and Replace
Shotgun Search and Replace is a multi-threaded application that does a recursive parse through a given folder, searching for and replacing with a given term amongst the various located text-based files. The types of files scanned are customizable using the config file located in the application folder. 

You can customise the search parameters for your search term by specifying whether to check in lowercase, uppercase, titlecase or as is.

The actual search and replace function is recursive in nature and split over five separate threads in order to decrease operation time. A backup of all replaced files are made in the root search folder.

Created by Craig Lotter, January 2008

*********************************

Project Details:

Coded in Visual Basic .NET using Visual Studio .NET 2008
Implements concepts such as String Replace, Search and Replace, Threading, File Manipulation.
Level of Complexity: Medium

*********************************

Update 20080223.02:

- Now allows for multiple search and replace pair sets to be inputted, using ';;' as the delimiter
