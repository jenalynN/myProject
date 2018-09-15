<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge"> 
    <meta content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" name="viewport">

    <meta name="description" content="">
    <meta name="author" content="">
    <title>CRUD Application</title>
    <link href="css/bootstrap.min.css" rel="stylesheet">
    <link href="css/dataTables.bootstrap.css" rel="stylesheet">
    <link href="css/sb-admin-2.css" rel="stylesheet">
    <link href="css/font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css">
</head>
<body>
    <div id="wrapper">
        <div id="page-wrapper">
            <div class="container-fluid">
                <div class="row">
                    <div class="col-lg-12">
                        <h1 class="page-header">HTML CRUD</h1>
                    </div>
                            <button class="btn btn-success btn-lg fa fa-user" data-toggle="modal" data-target="#myModal">
                                Create Account
                            </button>
                            <!-- Modal -->
                            <div class="modal fade" id="myModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
                                <div class="modal-dialog">
                                    <div class="modal-content">
                                        <div class="modal-header">
                                            <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                                            <h4 class="modal-title" id="myModalLabel">Add Member</h4>
                                        </div>
                                        
                                        <div class="modal-body">
                                            <div class="col-lg-12">
                                                 <form role="form" method="POST">
                                                    <div class="form-group input-group">
                                                        <span class="input-group-addon"><i class="fa fa-edit"></i></span>
                                                        <input type="text" class="form-control" name="fn" placeholder="First Name"  oninvalid="this.setCustomValidity('What is your first name?')" oninput="setCustomValidity('')" required>
                                                    </div>
						
                                                    <div class="form-group input-group">
                                                        <span class="input-group-addon"><i class="fa fa-edit"></i></span>
                                                        <input type="text" class="form-control" name="mn" placeholder="Middle Name"  oninvalid="this.setCustomValidity('What is your middle name?')" oninput="setCustomValidity('')" required>
                                                    </div>
							
                                                    <div class="form-group input-group">
                                                        <span class="input-group-addon"><i class="fa fa-edit"></i></span>
                                                        <input type="text" class="form-control" name="ln" placeholder="Last Name"  oninvalid="this.setCustomValidity('What is your last name?')" oninput="setCustomValidity('')" required>
                                                    </div>
                                            </div>
                                        </div>
                                        <div class="modal-footer">
                                            <div class="col-lg-12">
                                             <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                                                <button type="submit" class="btn btn-success" name="add_submit" >Register</button>
 						   
                                            </div>
                                        </div>
                                      </form>
                                    </div>
                                </div>
                            </div>

                            <hr>

            <div class="row">

                <div class="col-lg-12">
                        <?php 
                        require 'controller/controller.php';
                        add_member();
                        ?>
                    <div class="panel panel-default">
                        <div class="panel-heading">
                            Records.
                        </div>
                        <div class="panel-body">
                            <div class="dataTable_wrapper">
                                <table class="table table-striped table-bordered table-hover" id="dataTables-example">
                                    <thead>
                                        <tr>
                                            <th>#</th>
                                            <th>First Name</th>
                                            <th>Middle Name</th>
                                            <th>Last Name</th>
                                            <th>Action</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                    <?php 
                                    view_member();
                                    ?>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
                </div>
            </div>
        </div>
    </div>
    <script src="js/jquery.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <script src="js/jquery.dataTables.min.js"></script>
    <script src="js/dataTables.bootstrap.min.js"></script>
     <script>
    $(document).ready(function() {
        $('#dataTables-example').DataTable({
                responsive: true
        });
    });
    </script>
</body>
</html>
