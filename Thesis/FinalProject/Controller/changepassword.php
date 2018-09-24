<?php
include("db.php");

session_start();
// Get values paste from form in login.php file
// $password = "aaa";
$password = $_POST['cpassword'];
$userid = $_SESSION['userId'];
echo($userid);
$query = "UPDATE tbl_useraccounts SET col_password = $password WHERE col_useraccountsid = $userid ";
$result = mysql_query($db, $query);
// $rowcount=mysqli_num_rows($result);

return "Successfully updated!";

// if($rowcount == 1) 
// {
// 	$row = mysqli_fetch_assoc($result);
// 	$_SESSION['user'] = $username;
// 	$_SESSION['usertype'] = $row['col_usertypeid'];
// 	$_SESSION['userId']  = $row['col_useraccountsid'];
// 	header('Location:../index.php');  
// }

// else{ 
// 	header('Location:../login.php');
// }

?>