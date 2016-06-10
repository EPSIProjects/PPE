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

	echo ('<div class="table-responsive">
		<table class=".table-bordered">
			<thead>
				<tr>
					<td>Libellé formation</td>
					<td>Code formation</td>
					<td>Nom formateur</td>
					<td>Date de début</td>
					<td>date de fin</td>
				</tr>
			</thead>');

	while ($data = mysqli_fetch_assoc($result2)) {
		$sql_query_formateur = "SELECT nom_personnel FROM personnel WHERE fonction_personnel = 'F'";

		echo('<tbody>
					<tr>
						<td> '.$data['libelle_formation'].' </td>
						<td> '.$data['code_formation'].' </td>
						<td> '.$data['id_personnel_formation'].' </td>
						<td> '.$data['date_debut_formation'].' </td>
						<td> '.$data['date_fin_formation'].' </td>
					</tr>
				</tbody>');
	}
	echo ('</table>
		   </div>
















		');
}
else {
	echo "Erreur de connexion";
}




include '../footer.php';
?>