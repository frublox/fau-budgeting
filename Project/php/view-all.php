<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta http-equiv="description" content="Page used to display the form data to the asab user to approve or send back" />
    <title>Submissions</title>
</head>

<body>
    
    <?php /* To fully understand why a PHP class would be needed for this task, we should look at how this same task would be done without it. I will refer to databases as MySQL databases, so please bear with me, PostgreSQL fans.
    
    Take this as an example: We have 200 records, and we want to show 30 records at a time on our screens. This total of 200 records can grow with time, so we need to think dynamically here. I want to have "Next" and "Previous" links and also links to specific pages, like "1," "2," or whatever.
    
    For that, we need to determine the total number of records in our MySQL table. We can then get the number of pages by dividing the total number of records by the number of records we want to display on each screen, or 30. This is fairly easy to accomplish; just select everything from the table, get the number of rows returned by the query, and, there you go, you have the total and can calculate the number of pages.
    
    By the way, I had to use the function ceil() in the above example since the number of pages was wrong. If I had 100 records, and divided by 30 as in the example, the number of pages would be 3.33333. However, we need 4 pages to show all the records: 30 on the first, second and third, and 10 on the fourth one. So we always need to "round up" the number of pages.
    */ ?>
    
    <?php
    // database connection stuff here
    $rows_per_page = 30;
    $sql = "SELECT * FROM table_name";
    $result = mysql_query($sql, $db);
    $total_records = mysql_num_rows($result);
    $pages = ceil($total_records / $rows_per_page);
    mysql_free_result($result);
    ?>
    
    <?php /* Now we need to get the "limited" version of our query. Instead of getting all the rows back from the database, we only want 30 each time. MySQL and PostgreSQL both have a handy SQL function for this: LIMIT. They disagree on the order of the parameters, but they both accomplish the same task. MySql Syntax: SELECT * FROM table_name LIMIT 0, 30 which means "give me all columns from table table_name, but only 30 records, starting at record number 0." 
    
    We need to create screens showing a limited number of the returned rows using PHP and our handy LIMIT SQL function. We will use it to display the rows returned for each page, so the first page or screen of our script will show from record 0 to 29, the second screen from 30 to 59, and so on.
    */ ?>
    
    <?php
      var $numrowsperpage = 10;
      var $str_previous = "Previous page";
      var $str_next = "Next page";

      // These two variables are used internally 
      // by the class' functions
      var $file;
      var $total_records;
    ?>
    
    <?php
      function execute($sql, $db, $type = "mysql") {
        // global variables needed by the function
        global $total_records, $row, $numtoshow;

        // number of records to show at a time
        $numtoshow = $this->numrowsperpage;
        // $row is actually the number of the row of 
        // records (the page number)
        if (!isset($row)) $row = 0;
        // the record start number for the SQL query
        $start = $row * $numtoshow;
        // check the database type
        if ($type == "mysql") {
          $result = mysql_query($sql, $db);
          $total_records = mysql_num_rows($result);
          $sql .= " LIMIT $start, $numtoshow";
          $result = mysql_query($sql, $db);
        } elseif ($type == "pgsql") {
          $result = pg_Exec($db, $sql);
          $total_records = pg_NumRows($result);
          $sql .= " LIMIT $numtoshow, $start";
          $result = pg_Exec($db, $sql);
        }
        // returns the result set so the user 
        // can handle the data
        return $result;
      }
    ?>
    
    <?php /* Navigation Link Array - Since we already have executed our query, the navigation links can be created. This is an especially cool feature, since instead of printing out all the links in some pre-defined format, the class is actually returning an array with all the links (i.e., $array[0] holds <A HREF='example.php?row=0'>1</A>). This enables users to print the navigation links in whatever fashion they choose, adding even more customizability to the class.

    What it does is calculate the total number of pages that can be built according to the number of records per page the user selected. Then, it starts creating an array of links to return to the calling script. This is especially important, since a lot of user-defined options are available in this stage: whether to show page numbering links or not, whether to show the "Next" and "Previous" links or not, and whether to show the "Next" and "Previous" strings when those links are not needed.

    The first element of this array is always the "Previous" link/string. This means that $array[0] is always <A HREF='example.php?row=X'>Previous</A>, the string "Previous" or just blank. The last element of the array is the "Next" link/string, with the same possibilities as the first one. Finally, all the elements between the first and the last elements are the page numbering links/strings.

    Since the class doesn't affect how the script outputs the navigation link information in any way, the user is always free to customize the returned array to the page design.

    More on building the magic array

    Okay, by this point you may be a little bit confused, or even overwhelmed by so much information at once. The class can seem complex at first, but let's keep on analyzing it.

    The second assignment of the getlinks() function is to actually build the GET type URL that is going to be returned to the calling script. It is completely dynamic, so the options that the user chose in the previous script are remembered on the next screen.

    View contents of build_geturl() function here.

    All this function does is get the filename of the current script, or the requested URL and assign it to a class function for later use. It then checks for the form method type and builds a GET-type URL to be appended later to the navigation link's URL. That's how the class always knows and remembers the URL and variables passed to it.
    */ ?>
</body>
</html>