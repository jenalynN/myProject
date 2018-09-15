<?php 
	include 'db.php';
	include 'functions.php'; 
	include 'upload.php';
	include 'header.php';
?>
<?php


if (!empty($_POST["Add"])){
	$houseID=$_POST["houseID"];
	$houseNo=$_POST["houseNo"];
	$rate=$_POST["rate"];
	$houseName=$_POST["houseName"];
	$bedRoom=$_POST["bedRoom"];
	$bathRoom=$_POST["bathRoom"];
	$area=$_POST["area"];
	
	$picture=$_FILES["picture"];
	uploadPicture($picture);
	$target_file = "img/" . basename($picture["name"]);
	
	$sql = "INSERT INTO tb_house (houseNo, picture, rate, houseName, bedRoom, bathRoom, area)
	VALUES ('$houseNo','$target_file','$rate','$houseName','$bedRoom','$bathRoom','$area')";
	insertData ($sql);
}

if (!empty($_POST["Edit"])){
	$houseID=$_POST["houseID"];
	$houseNo=$_POST["houseNo"];
	$rate=$_POST["rate"];
	$houseName=$_POST["houseName"];
	$bedRoom=$_POST["bedRoom"];
	$bathRoom=$_POST["bathRoom"];
	$area=$_POST["area"];
	
	$picture=$_FILES["picture"];
	uploadPicture($picture);
	$target_file = "img/" . basename($picture["name"]);
	
	
	$sql = "UPDATE tb_house SET 
	houseNo='$houseNo',
	picture='$target_file',
	rate='$rate',
	houseName='$houseName',
	bedRoom='$bedRoom',
	bathRoom='$bathRoom',
	area='$area' 
	WHERE houseID=$houseID";
	
	updateData ($sql);
}

if (!empty($_POST["Delete"])){
	$houseID=$_POST["houseID"];
	
	$sql = "DELETE FROM tb_house WHERE houseID=$houseID";
	deleteData ($sql);
}

?>

<style>
body {
	 background-image: url("img/ss.JPG");
     background-size: 1400px;500px;
     background-repeat: no-repeat;
	 color:darkblue;
	 font:italic bold 15px/32px Georgia, serif;
}
table {

	font-family: arial, sans-serif;
    border-collapse: collapse;
	background-color:lightblue;
}

h1 {
	color:lightblue;
	text-align: center;
	font-family: "vivaldi";
	font-size:60px;

}

</style>

<div class="container">
<div class="row">
<h1>Rosita's House Rental and Reservation</h1>
<div class="col-sm-4">

	<form class="formHouse" action = "house.php" method = "post" enctype="multipart/form-data">
		<table >
		<table class="table table-bordered">
			<tr>
				<td>HouseID:</td>
				<td><input type = "number" class="form-control" placeholder="Enter HouseID" name = "houseID"></td>
			</tr>
			<tr>
				<td>HouseNo:</td>
				<td><input type= "number" class="form-control" placeholder="Enter HouseNo" name = "houseNo"></td>
			</tr>
			<tr>
				<td>Picture:</td>
				<td><input type = "file" class="form-control" placeholder="Enter Picture" name = "picture"></td>
			</tr>
			<tr>
				<td>Area:</td>
				<td><input type = "number" class="form-control" placeholder="Area" name = "area"></td>
			</tr>
			<tr>
				<td>HouseName:</td>
				<td><input type = "text" class="form-control" placeholder="Enter HouseName" name = "houseName"></td>
			</tr>
				<td>BedRoom:</td>
				<td><input type = "number" class="form-control" placeholder="BedRoom" name = "bedRoom"></td>
			</tr>
			<tr>
				<td>BathRoom:</td>
				<td><input type = "number" class="form-control" placeholder="Enter BathRoom" name = "bathRoom"></td>
		  </tr>
		  <tr>
				<td>Rate:</td>
				<td><input type = "number" class="form-control" placeholder="Enter Rate" name = "rate"></td>
		  </tr>
		</table>
		</table>
		<br>
		<div class="buttons">
		  <input class="btn btn-success" type="submit" name="Add" value="Add">
		  <input class="btn btn-success" type="submit" name="Edit" value="Edit">
		  <input class="btn btn-success" type="submit" name="Delete" value="Delete">
		</div>
	</form>
	</div>

	<div class="col">
	<div class="col-sm-8">
	<table class="table table-hover table-bordered">
		<tr>
			<th>HouseID</th>
			<th>HouseNo</th>
			<th>Picture</th>
			<th>Area</th>
			<th>HouseName</th>
			<th>BedRoom</th>
			<th>BathRoom</th>
			<th>Rate</th>
		</tr>
	<?php
	$sql = "SELECT * FROM tb_house";
	$result = selectData ($sql);
	while($row = $result->fetch_assoc()) {
		echo "<tr>";
		echo "<td>"	. $row["HouseID"]  . "</td>";	
		echo "<td>" . $row["HouseNo"]  . "</td>";
		echo "<td>" . $row["Picture"]  . "</td>";
		echo "<td>"	. $row["Area"]	   . "</td>";
		echo "<td>" . $row["HouseName"]. "</td>";
		echo "<td>"	. $row["BedRoom"]  . "</td>";
		echo "<td>" . $row["BathRoom"] . "</td>";
		echo "<td>" . $row["Rate"]     . "</td>";
		echo "</tr>";
	}
$conn->close();
	?>
	
	</table>
	</div>
</div>
</div>

</body>
</html>






