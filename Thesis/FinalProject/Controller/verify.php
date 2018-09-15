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

?>