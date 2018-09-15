<?php
include("db.php");
session_start();
// Get values paste from form in login.php file
$username = $_POST['username'];
$password = $_POST['password'];


$username = $conn->real_escape_string($username);

$query = "SELECT uname,pass FROM tb_login WHERE uname = '$username' AND pass='$password';";
$result = $conn->query($query);

if($result->num_rows == 1) 
{
	$_SESSION['user'] = $username;
	header('Location: Home.php');  
}

else{ 
	header('Location:login.php');
	
}


// to preventmysql injection
/* $user = stripcslashes('username');
$pass = stripcslashes('password'); */
/* $user = mysql_real_escape_string('username'); */
/* $pass = mysql_real_escape_string('password'); */

// connect to the server and selecct database

// Query the database for user
/* $result = mysql_query("select * from tb_login where username = '$username' and password = '$password'")
	or die("failed to query database". mysql_error());
$row = mysql_fetch_array($result);
if ($row['username']== $user && $row['password']== $pass){
	echo "Login success!!! Welcome ".$row['username'];
} else {
	echo "Failed to login!";
}*/
?> 