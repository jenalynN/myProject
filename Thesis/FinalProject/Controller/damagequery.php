<?php
function view_user()
{
	require ('Controller/db.php');
	if (!$db)
	{
		trigger_error('Could not connect to MySQL: ' . mysqli_connect_error());
	}	
					$result = mysqli_query($db,"SELECT * from tbl_transaction t 
					inner join tbl_damage d on t.col_transactionid = d.col_transactionid
					inner join tbl_product p on p.col_productid = d.col_productid
					");
									
						while ($row = mysqli_fetch_assoc($result))
						 {
							$Tcode = 	$row['col_transactioncode'];
							$Pcode= 	$row['col_productcode'];
							$Pname= 	$row['col_productname'];
							$Pprice= 	$row['col_productprice'];

						
							
							echo '<tr class="odd gradeX">
									<td>'.$Tcode.'</td>
									<td>'.$Pcode.'</td>
									<td>'.$Pname.'</td>
									<td>'.$Pprice.'</td>
									
								</tr>';
						 }
						}
							 					 
?>