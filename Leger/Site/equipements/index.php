
<?php $title="Équipements"; ?>
<?php include '../header.php'; ?>
<?php include '../connexion.php'; ?>
      <script type="text/javascript">
            document.getElementById("equipements").className = "active";
      </script>

<?php
        $query = 'select * from article';
        $result = mysqli_query($bdd, $query);


        echo '<table style="margin: auto; text-align: center; border: solid black 1px;">
            <tr>
                <td style="font-weight: bold">Équipement</td>
            </tr>';
            while ($donnees = mysqli_fetch_array($result, MYSQLI_ASSOC)){
                echo'<tr>
                    <td>'.$donnees ['libelle_article'].'<img src="../images/suit.jpg" height="75" widht="75"/></td>
                </tr>';
            }
        echo'</table>';
?>




<?php include '../footer.php'; ?>