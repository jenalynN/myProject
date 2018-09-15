<?php
session_start();
?>
<!DOCTYPE html>
<html lang="en">
<head>

  <title>Rosita's Reservation</title>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>

	
  </head>
  
<style>

.navbar-custom {
    background-color:#179b77;
    color:#ffffff;
    border-radius:0;
}

.navbar-custom .navbar-nav > li > a {
    color:#fff;
}


.navbar-custom .navbar-nav > li > a:hover,
.navbar-custom .navbar-nav > li > a:focus,
.navbar-custom .navbar-nav > .active > a:hover,
.navbar-custom .navbar-nav > .active > a:focus,
.navbar-custom .navbar-nav > .open >a {
    text-decoration: none;
    background-color: #33aa33;
}

.navbar-custom .navbar-brand {
    color:#eeeeee;
}

</style>
  
<body>
<div class="container">
	<nav class="navbar navbar-custom">
	  <div class="navbar-header">
		  <a class="navbar-brand" href="#">Rosita's Reservation</a>
		</div>
		<ul class="nav navbar-nav">
		  <li class="active"><a href="Home.php">Home</a></li>
		  <li><a href="About.php">About</a></li>
		  <li><a href="Contact.php">Contact</a></li>
		  <?php if(isset($_SESSION['user'])){ ?>
		  <li><a href="house.php">House</a></li>
		  <li><a href="motor.php">Motor</a></li>
		  <li><a href="customer.php">Customer</a></li>
		  <li><a href="reservation.php">Reservation</a></li>
		  <?php } ?>
		</ul>
		<ul class="nav navbar-nav navbar-right" style="margin-right:10px;">
		  <?php if(!isset($_SESSION['user'])){ ?>
		  <li><a href="login.php"><span class="glyphicon glyphicon-log-in"></span> Login</a></li>
		  <?php } else { ?>
		  <li><a href="session.php"><span class="glyphicon glyphicon-log-in"></span> Logout</a></li>
		  <?php } ?>
		</ul>
	  
	</nav>
</div>  