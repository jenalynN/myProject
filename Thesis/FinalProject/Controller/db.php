<?php
$servername = "localhost";
$username = "root";
$password = "";
$dbname = "db_poshconceptstorefinal";

// Create connection
$db = mysqli_connect($servername, $username, $password, $dbname);
	
// Check connection
if (!$db) {
    die("Connection failed: " . mysqli_connect_error());
}
//echo "Connected successfully";
?>

