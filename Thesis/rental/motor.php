<?php 
	include 'functions.php';
	include 'upload.php';
?>
<?php 
$servername = "localhost";
$username = "root";
$password = "";
$dbname = "db_rental";

// Create connection
$conn = new mysqli($servername, $username, $password, $dbname);

// Check connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}


if (!empty($_POST["add"])){
		$id = $_POST["id"];
		$plate = $_POST["plate"];
		$picture = $_FILES["picture"];
		$color = $_POST["color"];
		$brand = $_POST["brand"];
		$type = $_POST["type"];
		$rate = $_POST["rate"];
	uploadPicture($picture);
	$target_file = "img/" . basename($picture["name"]);
	//$sql = "INSERT INTO t_customer (name, email)
	//VALUES ('John Doe', 'john@example.com')";

	$sql = "INSERT INTO tb_motor(plateNo,picture,color,brand,type,rate)
	values('$plate','$target_file','$color','$brand','$type','$rate')";
	insertData($sql);
}

if (!empty($_POST["edit"])){
		$id = $_POST["id"];
		$plate = $_POST["plate"];
		$picture = $_POST["picture"];
		$color = $_POST["color"];
		$brand = $_POST["brand"];
		$type = $_POST["type"];
		$rate = $_POST["rate"];
		
	//$sql = "UPDATE t_customer SET name='Doe' WHERE id=1";
	//updateData($sql);

	$sql = "UPDATE tb_motor SET plateNo='$plate',picture = '$picture',color= '$color',brand = '$brand',type = '$type',rate = '$rate' WHERE motorID=$id";
	updateData($sql);
}
if (!empty($_POST["delete"])){
		$id = $_POST["id"];
		
	//$sql = "DELETE FROM t_customer WHERE id=1";
	//deleteData ($sql);

	$sql = "DELETE FROM tb_motor WHERE motorID=$id";
	deleteData($sql);
}

include 'header.php';
?>
<style>
body {
	 background-image: url("img/rr.JPG");
	 background-size: 1400px;500px;
     background-repeat: no-repeat;
	 color:darkblue;
	 font:italic bold 15px/32px Georgia, serif;
	 background-color:lightblue;
}
table {

	font-family: arial, sans-serif;
    border-collapse: collapse;
	background-color:#42bcf4;
}
h1 {
	color:lightblue;
	text-align: center;
	font-family: "vivaldi";
	font-size:60px;
}
#myInput {
  width: 100%;
  font-size: 16px;
  padding: 7px 20px 7px 20px;
  border: 2px solid #ggg;
  margin-bottom: 5px;
}
</style>
<div class = "container">
<div class = "row">
<h1>Rosita's Motorcycle Rental and Reservation</h1>
	<div class = "col-sm-4">
		
			<form action="motor.php" method="post" enctype="multipart/form-data">
			<table>
			<table class="table table-bordered">
				<tr>
					 <td>MotorID:</td>
					 <td><input type = "number" class="form-control" placeholder="Enter MotorID" name = "id"></td>
				</tr>
				<tr>
					<td>PlateNo:</td>
					<td><input type = "text" class="form-control" placeholder="Enter PlateNo" name = "plate"></td>
				</tr>
				<tr>
					<td>Picture:</td>
					<td><input type="file" name="picture"></td>				
				</tr>
				<tr>
					<td>Color:</td>
					<td><input type = "text" class="form-control" placeholder="Enter Color" name = "color"></td>
				</tr>
				<tr>
					<td>Brand:</td>
					<div class = "dropdown">
					<td><select name='brand'>
						<?php
							$sql=mysqli_query($conn, "SELECT * FROM motorBrand");
							while ($brand=mysqli_fetch_assoc($sql)) {
							
						?>
							<option value = "<?php echo $brand['motorBrand']; ?>"> <?php echo $brand['motorBrand'];?> </option>

							<?php
								}
							?>
								
							</select>
				</tr>
				<tr>
					<td>Type:</td>
					<div class = "dropdown">
					<td><select name='type'>
						<?php
							$sql=mysqli_query($conn, "SELECT * FROM motorType");
							while ($type=mysqli_fetch_assoc($sql)) {
							
						?>
							<option value = "<?php echo $type['motorType']; ?>"> <?php echo $type['motorType'];?> </option>

							<?php
								}
							?>
								
							</select>
				</tr>
				<tr>
					<td>Rate:</td>
					<td><input type = "number" class="form-control" placeholder="Enter Rate" name = "rate"></td>
				</tr>
			</table>
			</table>
			<br>
			<div class="btn-group">
				<input class="btn btn-success" type= "submit" name = "add" value = "Add">
				<input class="btn btn-success" type= "submit" name = "edit" value = "Edit">
				<input class="btn btn-success" type= "submit" name = "delete" value = "Delete">
			</div>
			</form>
		</div>
		<div class = "col-sm-8">
		<input type="text" id="Input" onkeyup="myFunction()" placeholder="Search..." title="Type in a name">
		<table id="Table">
			<table class="table table-hover table-bordered">
				<tr>
					<th>Motor Id</th>
					<th>Plate No</th>
					<th>Picture</th>
					<th>Color</th>
					<th>Brand</th>
					<th>Type</th>
					<th>Rate</th>
				</tr>
<?php
		$sql = "SELECT * FROM tb_motor";
		$result = selectData($sql);
 		while($row = $result->fetch_assoc()) {
			
					echo "<tr>"	;
					echo "<td>"	.$row["motorID"]."</td>";
					echo "<td>"	.$row["plateNo"]."</td>";
					echo "<td>"	.$row["picture"]."</td>";
					echo "<td>"	.$row["color"]."</td>";
					echo "<td>"	.$row["brand"]."</td>";
					echo "<td>"	.$row["type"]."</td>";
					echo "<td>"	.$row["rate"]."</td>";
					echo "</tr>";
					} 
		$conn -> close();
?>			
			</table>
		</div>
	</div>
</div>
<script>
function myFunction() {
  var input, filter, table, tr, td, i;
  input = document.getElementById("Input");
  filter = input.value.toUpperCase();
  table = document.getElementById("Table");
  tr = table.getElementsByTagName("tr");

  for (i = 0; i < tr.length; i++) {
    td = tr[i].getElementsByTagName("td")[1];
    if (td) {
      if (td.innerHTML.toUpperCase().indexOf(filter) > -1) {
        tr[i].style.display = "";
      } else {
        tr[i].style.display = "none";
      }
    } 
  }
}
</script>
</body>
</html>