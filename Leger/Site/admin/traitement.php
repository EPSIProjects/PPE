<?php
$title="Panel d'administration";

htmlentities('azéoràèndjùd', ENT_COMPAT, 'UTF-8');

include("../header.php");

$bdd = mysqli_connect("sql.franceserv.fr","paravent","paravent1234","darkmath_db2");
	$username = mysqli_real_escape_string($bdd, $_POST['user']);
	$password = mysqli_real_escape_string($bdd, $_POST['password']);


$sql_query = "SELECT * FROM personnel WHERE identifiant_personnel=\"".$username."\" AND mot_de_passe_personnel=\"".$password."\"";
$result = mysqli_query($bdd, $sql_query);
$row = mysqli_fetch_array($result, MYSQLI_ASSOC);
$count = mysqli_num_rows($result);

if ($count == 1) {
	
	$sql_query2 = "SELECT * FROM formation";
	$result2 = mysqli_query($bdd, $sql_query2);

	echo ('<div class="row">
		<div class="table-responsive col-md-12">
			<table class="table-bordered TabCel col-md-12">
				<thead>
					<tr>
						<td><h4>Libellé formation</h4></td>
						<td class="Marg"><h4>Code formation</h4></td>
						<td><h4>Nom formateur</h4></td>
						<td><h4>Date de début</h4></td>
						<td><h4>Date de fin</h4></td>
					</tr>
				</thead>');
	$i=0;
	while ($data = mysqli_fetch_assoc($result2)) {

		echo('<tbody>
					<tr>
						<td class="Col1"> <input class="form-control LibForm" type="text" name="Libelle-formation" value="'.$data['libelle_formation'].'"></td>
						<td class="Col2"> <input class="form-control" type="text" name="Code-formation" value="'.$data['code_formation'].'"</td>
						<td class="Col3"> <select id="mySelect'.$i.'">');
						$sql_query_formateur = "SELECT id_personnel, nom_personnel FROM personnel WHERE fonction_personnel = 'F'";
						$result3 = mysqli_query($bdd, $sql_query_formateur);
						while ($formateur = mysqli_fetch_assoc($result3)) {
							echo ('<option value="'.$formateur['id_personnel'].'">'.$formateur['nom_personnel'].'</option>');
						}
						echo ('</select> </td>
							<script>
    							document.getElementById("mySelect'.$i.'").value = "'.$data['id_personnel_formation'].'";
							</script>
						<td class="Col4"> '.$data['date_debut_formation'].' </td>
						<td class="Col5"> '.$data['date_fin_formation'].' </td>
					</tr>
				</tbody>');
						$i++;
	}
	echo ('	</table>
		
			</div>
		    </div>
















		');
}
else {
	echo "Erreur de connexion";
}




include '../footer.php';
?>