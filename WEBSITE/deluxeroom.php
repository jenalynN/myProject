<?php
    session_start();

    //connect to database
    $db = mysqli_connect("localhost","root","","web");

    if(isset($_POST['submit'])){
        $fname = mysql_real_escape_string($_POST['fname']);
        $lname = mysql_real_escape_string($_POST['lname']);
        $address = mysql_real_escape_string($_POST['address']);
        $contact = mysql_real_escape_string($_POST['contact']);
        $room = mysql_real_escape_string($_POST['room']);
        $date = mysql_real_escape_string($_POST['date']);
        $date2 = mysql_real_escape_string($_POST['date2']);

        if ( $fname == "" || $lname == "" || $address == "" || $contact == "" || $room == "" ) {
            $_SESSION['message'] = "Please fill all the need information";
            header("location: deluxeroom.php?error=1");

        }
        else {
            $sql = "INSERT INTO tblweb(firstname,lastname,address,contact,room,start,end) VALUES ('$fname','$lname','$address','$contact','$room','$date','$date2')";
            mysqli_query($db, $sql);
            $_SESSION['message'] = "Submitted Complete.";
            header("location: deluxeroom.php");
        }
    }
?>
<!DOCTYPE html>
<html>
    <head> 
        <title>Deluxe Room - Booking</title>
        <link rel="stylesheet" type="text/css" <link rel="stylesheet" href="style.css">
    </head>
    <body>
        <div id="main">
         <nav>
             <ul>
                    <li><a href="home.html">Home</a></li>               
              <ul>
            </nav>
<div id= "containera">
            <div id="row30a">
               <h1> Deluxe Room </h1>
           
            
            </div id=row70a>
            <form method="post" action="deluxeroom.php">
                <table>
		    <tr>
                        <td><h1>Room Type: </h1></td>
                        <td><input type="text" name="room" class="textInput" style="font-size:18pt;" value="Deluxe Room" readonly ></td>
            </tr>
                    <tr>
                        <td><h1>First Name: </h1></td>
                        <td><input type="text" name="fname" class="textInput" style="font-size:18pt;" ></td>
                    </tr>
                    <tr>
                        <td><h1>Last Name:</h1></td>
                        <td><input type="text" name="lname" class="textInput" style="font-size:18pt;"></td>
                    </tr>
                    <tr>
                        <td><h1>Address:</h1> </td>
                        <td><input type="text" name="address" class="textInput" style="font-size:18pt;" ></td>
                    </tr>
                    <tr>
                        <td><h1>Contact Number: </h1></td>
                        <td><input type="number" name="contact" class="textInput" style="font-size:18pt;"></td>
                    </tr>
                    <tr>
                        <td><h1>Starting Date: </h1></td>
                        <td><input type="date" name="date" class="textInput" style="font-size:18pt;" min="2017-10-26"  ></td>
                    </tr>
                     <tr>
                       
                        <td><h1>Ending Date: </h1> </td>
                        <td><input type="date" name="date2" class="textInput" style="font-size:18pt;"></td>
                    </tr>
                    <tr>
                        
                         
                    </tr>
                    
                </table>

                <td><button type="button1" name="submit" style="width:500px"><strong>Book</strong></button></td>
            </form>
            </div>
  </div>
        </div>


      
 

    </body>
</html>