
<html>
<head>
	<title>Login</title>
	<link rel="stylesheet" type="text/css" href="mystyle.css" /> 
</head>
<body>
<form action="process.php" method="POST">
  <div class="imgcontainer">
    <img src="img/user.png" alt="User" class="user" width="200" height="200">
  </div>

  <div class="">
    <label><b>Username</b></label>
    <input type="text" placeholder="Enter Username" name="username" required>

    <label><b>Password</b></label>
    <input type="password" placeholder="Enter Password" name="password" required>
        
    <button type="submit" name="submit">Login</button>
    
  </div>
  <div class="">
	<button type="button" class="cancelbtn" onclick="location.href='Home.php';">Home</button>
    <button type="reset" class="cancelbtn">Cancel</button>
   
  </div>
</form>

</body>
</html>

