<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta http-equiv="description" content="Page used to display the form data to the asab user to approve or send back" />
    <title>Request Form</title>
</head>
    
<body>
        <?php 
        if(!$_POST['submit']) {
            echo "No data entered.";
        }
        else {
            $smarttag = $_POST['smarttag'];
            $accountname = $_POST['accountname'];
            $transferin1 = $_POST['transferin1'];
            $transferin2 = $_POST['transferin2'];
            $transferin3 = $_POST['transferin3'];
            $transferin4 = $_POST['transferin4'];
            $transferin5 = $_POST['transferin5'];
            $transferin6 = $_POST['transferin6'];
            $equipment = $_POST['equipment'];
            $improvements = $_POST['improvements'];
            $contingencies1 = $_POST['contingencies1'];
            $contingencies2 = $_POST['contingencies2'];
            $contingencies3 = $_POST['contingencies3'];
            $contingencies4 = $_POST['contingencies4'];
            $contingencies5 = $_POST['contingencies5'];
            $contingencies6 = $_POST['contingencies6'];
            $contingencies7 = $_POST['contingencies7'];
            $contingencies8 = $_POST['contingencies8'];
            $contingencies9 = $_POST['contingencies9'];
            $transferout1 = $_POST['transferout1'];
            $transferout2 = $_POST['transferout2'];
            $transferout3 = $_POST['transferout3'];
            $transferout4 = $_POST['transferout4'];
            $transferout5 = $_POST['transferout5'];
            $transferout6 = $_POST['transferout6'];
            
            echo ("SmartTag: " . $smarttag . "<br> Account Name: " . $accountname . "<br> Fund: Student Government Reserve <br> Transfer In:     2018-2019 Request Budget <br>" . $transferin1 . "         " . $transferin2 . "<br>" . $transferin3 . "        " . $transferin4 . "<br>" . $transferin5 . "          ". $transferin6);
        }
        ?>
</body>
</html>