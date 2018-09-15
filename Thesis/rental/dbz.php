<?php
/* $servername = "localhost";
$usernames = "root";
$passwords = "";
$dbname = "db_rental";
 */
// Create connection
$conn= new mysqli('localhost', 'root', '', 'db_rental');

// Check connection
if ($conn->connect_error) {	
    die("Connection failed: " . $conn->connect_error);
}	