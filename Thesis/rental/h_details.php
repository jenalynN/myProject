<?php 
include 'db.php';
include 'functions.php';
include 'header.php';
 
?>

<?php 

		if(!empty($_POST["Next"])){

		
		$fname= $_POST["fname"];
		$lname=$_POST["lname"];
		$gender=$_POST["gender"];
		$email=$_POST["email"];
		$cnumber=$_POST["cnumber"];
		$address=$_POST["address"];
		
		$sql= "INSERT INTO tb_costumer(F_name,L_name,gender,email,contactNo,address)
		VALUES ('$fname','$lname','$gender','$email','$cnumber','$address')";
		insertData($sql);
		header("Location: agreement.php");
		}

?>

<style>
	.field-wrap {
  position: relative;
  margin-bottom: 8px;

}
</style>
<body>
<div class="container">
	<h3>Customer and Payment Details</h3>

	<div class="row">
		<div class="col-sm-4">
			<div class="panel panel-default">
			<div class="panel-body">
			<form action='h_details.php' method="post">
				<div>
				<table>
					<div class="field-wrap">
					<tr>	
						<select name='title'>
							<option value="Mr."> Mr.</option>
							<option value="Ms."> Ms.</option>
							<option value="Mrs."> Mrs.</option>
						</select>
						
					</tr>
					<div class="field-wrap">
						<tr>
							<input type="text" class="form-control" placeholder="Enter Firstname" name="fname">
						</tr>

					<div class="field-wrap">
						<tr>
							<input type="text" class="form-control" placeholder="Enter Lastname" name="lname">
						</tr>

					<div class="field-wrap">
						<tr>
						<select name='gender'>
							<option value="gender">Gender</option>
							<option value="male"> Male</option>
							<option value="female"> Female</option>
							
						</select>
						</tr>

						
					<div class="field-wrap">
						<tr>
							<input type="email" class="form-control" placeholder="Enter email" name="email">
						</tr>
					</div>
					<div class="field-wrap">
						<tr>
							<input type="number" class="form-control" placeholder="Enter Contact number" name="cnumber">
						
						</tr>
					</div>
					<div class="field-wrap">
						<tr>	
							<input type="text" class="form-control" placeholder="Enter Address" name="address" >
						</tr>
					</div>
				</table>
				</div>
				
			</div>
			</div>
		</div>



	<div class="col-sm-8">
			<div class="panel panel-default">
			<div class="panel-body">
				<table class="table " >
					<thead>
						<tr>
							<th>House charges</th>
						</tr>
					</thead>
				
						<tr>
							<td>Area:</td>
						
						</tr>
						<tr>
							<td>BedRoom:</td>
						
						</tr>
						<tr>
							<td>BathRoom:</td>
						
						</tr>
						<tr>
							<td>Total:</td>
						
						</tr>
				</table>

			</div>
			</div>
				<input class="btn btn-primary" type="submit" name="Next" value="Next">
			</form>

			
			
	</div>
	
</div>

</body>
