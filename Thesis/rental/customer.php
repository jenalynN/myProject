<?php 
include 'db.php';
include 'functions.php';
include 'header.php';
 
?>

<?php



		if(!empty($_POST["Add"])){

		$cusid= $_POST["custID"];
		$fname= $_POST["fname"];
		$lname=$_POST["lname"];
		$age=$_POST["age"];
		$address=$_POST["address"];
		$gender=$_POST["Gender"];
		$cnumber=$_POST["cnumber"];
		$email=$_POST["email"];
		$id_provided=$_POST["id_provided"];
		$id_number=$_POST["id_number"];

		$sql= "INSERT INTO tb_costumer(customerID,F_name,L_name,age,address,gender,contactNo,email,ID_provided,ID_number)
		VALUES ('$cusid','$fname','$lname','$age','$address','$gender','$cnumber','$email','$id_provided','$id_number')";
		insertData($sql);
		}

	if(!empty($_POST["Delete"])){

		$cusid= $_POST["custID"];
		
		$sql= "DELETE FROM tb_costumer where customerID=$cusid";
		
		deleteData($sql);
		}
	if(!empty($_POST["EDIT"])){

		$cusid= $_POST["custID"];
		$fname= $_POST["fname"];
		$lname=$_POST["lname"];
		$age=$_POST["age"];
		$address=$_POST["address"];
		$gender=$_POST["Gender"];
		$cnumber=$_POST["cnumber"];
		$email=$_POST["email"];
		$id_provided=$_POST["id_provided"];
		$id_number=$_POST["id_number"];

		$sql= "UPDATE tb_costumer set F_name='$fname', L_name='$lname', age='$age',address='$address', gender='$gender',contactNo='$cnumber',email='$email',ID_provided='$id_provided', ID_number='id_number'  where customerID=$cusid";
		
		updateData($sql);
		}

	
?>
<style>
body {
	 background-image: url("img/vel.jpg");
     background-size: 1500px;500px;
     background-repeat: no-repeat;
	 color:darkblue;
	 font:italic bold 15px/32px Georgia, serif;
	 background-color:#318e36;

}
table {

	font-family: arial, sans-serif;
    border-collapse: collapse;
	background-color:lightblue;
}

h1 {
	color:darkblue;
	text-align: center;
	font-family: "vivaldi";
	font-size:60px;
}
	
</style>

<div class="container">
	<h1>Customer's Information</h1>
	 <div style = 'margin-left: 800px;'>
            <form action="customer.php" method="POST">
                <input type="text" name="search_keyword">
                <input type="submit" name="search" class = 'btn btn-primary' value="Search Book">
                
            </form>
        </div>
  				
	<div class="row">
		<div class="col-sm-4">
			<div class="panel panel-default">
			<div class="panel-body">
			<form action='customer.php' method="post">
			
				<table>
					<tr>
					
						<td>Customer ID:</td>
						<td><input type="number" class="form-control" placeholder="Enter customer ID" name="custID"></td>
					</tr>
					<tr>

						<td>Firstname:</td>
						<td><input type="text" class="form-control" placeholder="Enter Firstname" name="fname"></td>
					</tr>
					<tr>
						<td>Lastname:</td>
						<td><input type="text" class="form-control" placeholder="Enter Lastname" name="lname"></td>
					</tr>
					<tr>
						<td>Age:</td>
						<td><input type="number" class="form-control" placeholder="Enter Age" name="age"></td>
					</tr>
					<tr>
						<td>Address:</td>
						<td><input type="text" class="form-control" placeholder="Enter Address" name="address"></td>
					</tr>
				
						<td>Gender:</td>
					
						<td><input type="radio" value="male" name="Gender">Male <input type="radio"  value="female" name="Gender">Female</td>
						 
					</tr>
					<tr>
						<td>Contact Number:</td>
						<td><input type="number" class="form-control" placeholder="Enter Contact number" name="cnumber" ></td>
					</tr>
					<tr>
						<td>Email:</td>
						<td><input type="email" class="form-control" placeholder="Enter email" name="email"></td>
					</tr>
					<tr>
						<td>Type of ID:
						<td><select name='id_provided'>
						<?php
							$sql=mysqli_query($conn, "SELECT * FROM typeofid");
							while ($type=mysqli_fetch_assoc($sql)) {
							
						?>
							<option value = "<?php echo $type['type']; ?>"> <?php echo $type['type'];?> </option>

							<?php
								}
							?>
								
							</select>

					</td>
					</tr>
					<tr>
						<td>ID_number:</td>
						<td><input type="text" class="form-control" placeholder="Enter ID number" name="id_number"></td>
					</tr>
					</table>
				</table>
			</div>
			</div>
				<br>
				<div class="buttons">
				<input class="btn btn-success" type="submit" name="Add" value="Add">
				<input class="btn btn-success" type="submit" name="Edit" value="Edit">
				<input class="btn btn-success" type="submit" name="Delete" value="Delete">
				
		</div>


			</form>
		</div>
		<div class="col-sm-8">
			<table class="table table-hover">
				<tr>
					<th>CustomerID</th>
					<th>Firstname</th>
					<th>Lastname</th>
					<th>Age</th>
					<th>Address</th>
					<th>Gender</th>
					<th>Contact Number</th>
					<th>Email</th>
					<th>ID provided</th>
					<th>ID number</th>
				</tr>
<?php
		$sql = "SELECT * FROM tb_costumer ";
		$result = selectData ($sql);
		while($row = $result->fetch_assoc()) {
			
				echo "	<tr>"	;
				echo "	<td>" .	$row["customerID"] .	"</td>";
				echo "	<td>" .	$row["F_name"]	   .	"</td>";
				echo "	<td>" .	$row["L_name"]	   .	"</td>";
				echo "	<td>" .	$row["age"] 	   .	"</td>";
				echo "	<td>" .	$row["address"]	   .	"</td>";
				echo "	<td>" .	$row["gender"]	   .	"</td>";
				echo "	<td>" .	$row["contactNo"]  .	"</td>";
				echo "	<td>" .	$row["email"]      .	"</td>";
				echo "	<td>" .	$row["ID_provided"].	"</td>";
				echo "	<td>" .	$row["ID_number"]  .	"</td>";
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