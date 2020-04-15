# ShoeCollectionWithDatabase

# Summary
Shoe collection program using a database to store information. Currently this is programmed to use a local SQL Server on my desktop,
looking to expand upon this program later on to have a local database made making it useable on many other devices

## A Peek Inside
----------------
### _Main Menu_
![The Main Menu](https://github.com/giancarlo-david/ShoeCollectionWithDatabase/blob/master/Pictures/Main%20Menu.JPG)
  * Displays the list of shoes stored within the database in a table form
  * Displays the current shoe count in the top right
  * Displays current shoe selected on the bottom
  * Provides buttons for user to open up the add shoe form, delete current shoe, or exit program
  
### _Add Shoe Form_
![Add Shoe Form](https://github.com/giancarlo-david/ShoeCollectionWithDatabase/blob/master/Pictures/Add%20Shoe.JPG)
  * Provides drop down combo boxes for the user to pick the shoe's brand (restricted by brands within the database)
    and the size of shoe
  * Provides text boxes allowing for user input for the model and colorway of the shoe
  * Add button adds the user input to the database
  * Finish button completes the adding process and brings the user back to the main menu
  
### _Remove Shoe_
![Remove Shoe Prompt](https://github.com/giancarlo-david/ShoeCollectionWithDatabase/blob/master/Pictures/Remove.JPG)
  * Provides a prompt verifiying that the user wants to delete the current shoe when remove button is pressed
  * Once user confirms removal, the shoe is removed from the database and user is provided dialog that the shoe was removed
