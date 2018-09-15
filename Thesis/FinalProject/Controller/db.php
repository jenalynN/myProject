<?php
//database
define('DB_HOST', '127.0.0.1');
define('DB_USERNAME', 'root');
define('DB_PASSWORD', '');
define('DB_NAME', 'db_poshconceptstorefinal');

// Create connection
$db = mysqli_connect(DB_HOST, DB_USERNAME, DB_PASSWORD, DB_NAME);
	
// Check connection
if (!$db) {
    die("Connection failed: " . mysqli_connect_error());
}
//echo "Connected successfully";
?>

