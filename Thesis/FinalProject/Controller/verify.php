<?php
include("db.php");

//session_start();
// Get values paste from form in login.php file
$username = $_POST['uname'];
$password = $_POST['psw'];


//$username = $db->real_escape_string($username);

$query = "SELECT * FROM tbl_useraccounts WHERE col_user = '$username' AND col_password ='$password';";
$result = mysqli_query($db, $query);
$rowcount=mysqli_num_rows($result);

if($rowcount == 1) 
{
	$_SESSION['user'] = $username;
	header('Location:../sales.php');  
}

else{ 
	header('Location:../login.php');
}

?>