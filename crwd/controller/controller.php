
    <?php 
    
        function add_member() {
            if (isset($_POST['add_submit'])) {
            require 'controller/config.php';
                $fn = mysqli_real_escape_string($db,$_POST['fn']);
                $mn = mysqli_real_escape_string($db,$_POST['mn']);
                $ln = mysqli_real_escape_string($db,$_POST['ln']);
                $result = mysqli_query($db,"INSERT INTO tbl_blood (col_bloodtype,col_bagsleft,col_price) VALUES ('$fn','$mn','$ln')");
                echo
        '
                 <div class="alert alert-success">
                    Successfully Recorded
                 </div>
        ';

    }
}

		
		function view_member() {
			require 'controller/config.php';	
				$result = mysqli_query($db,"SELECT * FROM tbl_blood");
					while ($row = mysqli_fetch_assoc($result)) {
						$id = $row['col_bloodid'];
						$fn = $row['col_bloodtype'];
						$mn = $row['col_bagsleft'];
						$ln = $row['col_price'];
						echo 
							'
                            <tr class="odd gradeX">
                                <td style="width:50px">'.$id.'</td>
                                <td>'.$fn.'</td>
                                <td>'.$mn.'</td>
                                <td>'.$ln.'</td>
                                <td style="width:100px;text-align:center">
                                <a style="cursor:pointer" data-toggle="modal" data-target="#ModalEdit'.$id.'" title="Edit"><i class="fa fa-edit"></i></a>
                                <a style="cursor:pointer" data-toggle="modal" data-target="#ModalDelete'.$id.'" title="Delete"><i class="fa fa-remove"></i></a>
                                </td>
                            </tr>

							
							<div class="modal fade" id="ModalEdit'.$id.'" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
                                <div class="modal-dialog">
                                    <div class="modal-content">
                                        <div class="modal-header">
                                            <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                                            <h4 class="modal-title" id="myModalLabel">Modify Record</h4>
                                        </div>
                                        
                                        <div class="modal-body">
                                            <div class="col-lg-12">
                                                 <form role="form" method="POST">
                                                    <input type="hidden" name="edit_id" value="'.$id.'">
                                                    <div class="form-group input-group">
                                                        <span class="input-group-addon"><i class="fa fa-edit"></i></span>
                                                        <input type="text" class="form-control" name="fn" placeholder="First Name" value="'.$fn.'">
                                                    </div>

                                                    <div class="form-group input-group">
                                                        <span class="input-group-addon"><i class="fa fa-edit"></i></span>
                                                        <input type="text" class="form-control" name="mn" placeholder="Middle Name" value="'.$mn.'">
                                                    </div>

                                                    <div class="form-group input-group">
                                                        <span class="input-group-addon"><i class="fa fa-edit"></i></span>
                                                        <input type="text" class="form-control" name="ln" placeholder="Last Name" value="'.$ln.'">
                                                    </div>
                                            </div>
                                        </div>
                                        <div class="modal-footer">
                                            <div class="col-lg-12">
                                                <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                                                <button type="submit" class="btn btn-info" name="edit_submit" ><i class="fa fa-refresh"></i> Update Records</button>
                                            </div>
                                        </div>
                                      </form>
                                    </div>
                                </div>
                            </div>


                            <div class="modal fade" id="ModalDelete'.$id.'" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
                                <div class="modal-dialog">
                                    <div class="modal-content">
                                        <div class="modal-header">
                                            <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                                            <h4 class="modal-title" id="myModalLabel">Delete Record</h4>
                                        </div>
                                        
                                        <div class="modal-body">
                                            <div class="col-lg-12">
                                                 <form role="form" method="POST">
                                                   Are you sure you want to delete this record?
                                                   <input type="hidden" name="delete_id" value="'.$id.'">
                                            </div>
                                        </div>
                                        <div class="modal-footer">
                                            <div class="col-lg-12">
                                                <button type="button" class="btn btn-primary" data-dismiss="modal">No <i class="fa fa-refresh"></i></button>
                                                <button type="submit" class="btn btn-danger" name="delete_submit" ><i class="fa fa-check"></i> Yes</button>
                                            </div>
                                        </div>
                                      </form>
                                    </div>
                                </div>
                            </div>
                            ';
					}

					if (isset($_POST['delete_submit'])) {
						$delete_id = $_POST['delete_id'];
						$del_result = mysqli_query($db,"DELETE FROM crud_account_tbl WHERE id ='$delete_id'");
						echo '<script>window.location.href="index.php"</script>';
					}

                    if (isset($_POST['edit_submit'])){
                        require 'controller/config.php';
                        $edit_id = $_POST['edit_id'];
                        $fn = mysqli_real_escape_string($db,$_POST['fn']);
                        $mn = mysqli_real_escape_string($db,$_POST['mn']);
                        $ln = mysqli_real_escape_string($db,$_POST['ln']);
                        $edit_result = mysqli_query($db,"UPDATE crud_account_tbl SET fn ='$fn', mn ='$mn', ln ='$ln' WHERE id ='$edit_id'");
                        echo '<script>window.location.href="index.php"</script>';
                    }
		}
	
