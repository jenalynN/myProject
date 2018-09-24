<?php
function view_product()
{
	require ('Controller/db.php');
	if (!$db)
	{
		trigger_error('Could not connect to MySQL: ' . mysqli_connect_error());
	}	
					$result = mysqli_query($db,"select * from tbl_product P
                INNER JOIN tbl_brandpartner B ON P.col_useraccountsid = B.col_useraccountsid 
                INNER JOIN tbl_category C ON C.col_categoryid = P.col_categoryid 
                where P.col_status='unarchived'");
									
						while ($row = mysqli_fetch_assoc($result))
						 {
							$pcode= $row['col_productcode'];
							
							echo '<tr class="">
									<td>'.$pcode.'</td>
									
								</tr>';
						 }
						}
							 					 
?>