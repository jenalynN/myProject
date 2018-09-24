<?php
include("db.php");

session_start();
// Get values paste from form in login.php file
$username = $_POST['uname'];
$password = $_POST['psw'];


//$username = $db->real_escape_string($username);

$query = "SELECT * FROM tbl_useraccounts WHERE col_user = '$username' AND col_password ='$password' and col_usertypeid != 2;";
$result = mysqli_query($db, $query);
$rowcount=mysqli_num_rows($result);


if($rowcount == 1) 
{
	$row = mysqli_fetch_assoc($result);
	$_SESSION['user'] = $username;
	$_SESSION['usertype'] = $row['col_usertypeid'];
	$_SESSION['userId']  = $row['col_useraccountsid'];
	header('Location:../index.php');  
}

else{ 
	header('Location:../login.php');
}

?>