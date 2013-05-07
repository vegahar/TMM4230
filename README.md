TMM4230
----------------
Excercise 2
The following should be delivered in this excercise:
• A packed (ZIP, RAR or similar) version of your Visual Studio solution. To decrease the file size, 
the ”bin”- and ”obj”-folders can be removed before packing.
• A textfile or document that gives a brief description of how the application is constructed, 
and what the different parts of the program does.
The application should be made in two parts:

Server/Web service:
This part shall contain a list of people/persons. There should be information about first name, last 
name and age for each person. The list of people should then be available through a web service.
When asking for a list of people, it should be possible to ask for all people, search for parts of a 
name, or search for an exact age. The search functionality for names does not need to be advanced, 
it is OK to just check if the search string is a substring of "'First name' 'Last name'". The searching 
should be done on the server side of the application, and not after the client has received a list 
containing information about every person.

Client:
Should be a graphical user interface to ask the server about its list of people. How this looks is up to 
you, but the functionality to get all people, and search for names and age must be included. The 
client should be made either as a Windows Forms application or a Silverlight

