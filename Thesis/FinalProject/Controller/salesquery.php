<?php
function view_sales()
{
	require ('Controller/db.php');
	if (!$db)
	{
		trigger_error('Could not connect to MySQL: ' . mysqli_connect_error());
	}	
					$result = mysqli_query($db,"SELECT * from tbl_order o
					inner join tbl_product p on o.col_productid = p.col_productid
					inner join tbl_transaction t on o.col_transactionid = t.col_transactionid
					");
									
						while ($row = mysqli_fetch_assoc($result))
						 {
							$tcode = 			$row['col_transactioncode'];
							$datepurchased= 	$row['col_dateofpurchase'];
							$pcode= 			$row['col_productcode'];
							$productname = 		$row['col_productname'];
							$price =			$row['col_productprice'];	
							$quantity = 		$row['col_quantitybought'];
							$subtotal = 		$row['col_subtotal'];
							
							echo '<tr class="">
									<td>'.$datepurchased.'</td>
									<td>'.$tcode.'</td>
									<td>'.$pcode.'</td>
									<td>'.$productname.'</td>
									<td>'.$price.'</td>
									<td>'.$quantity.'</td>
									<td>'.$subtotal.'</td>
									
								</tr>';
						 }
						}
							 					 
?>