<?php 
include 'db.php';
include 'functions.php';
include 'header.php';
 
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
			<form action='m_details.php' method="post">
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
				</form>
			</div>
			</div>
		</div>
	
	<div class="col-sm-8">
			<div class="panel panel-default">
			<div class="panel-body">
				<table class="table " >
					<thead>
						<tr>
							<th>Motor charges</th>
						</tr>
					</thead>
				
						<tr class="col col-sm-4">
							<td>Total:
						</tr>
				</table>
			</div>
			</div>

			<div class="panel panel-default">
			<div class="panel-body">
				<table class="table " >
					<thead>
						<tr>
							<td>Deposit due now</td>
						</tr>
					</thead>
				
						<tr class="">
							<td>Balance due on arrival</td>
						</tr>
				</table>
			</div>
			</div>

			<div class="panel panel-default">
			<div class="panel-body">
				<table class="table " >
					<thead>
						<tr>
							<th>Payment method</th>
						</tr>
					</thead>
				
				</table>
			</div>
			</div>
	</div>
</div>
