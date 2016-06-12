<?php $title="Équipements"; ?>
<?php include '../header.php'; ?>
<?php include '../connexion.php'; ?>
      <script type="text/javascript">
            document.getElementById("equipements").className = "active";
      </script>

    <h1>Equipements</h1>
<?php
        $query = 'select * from article order by libelle_article asc';
        $result = mysqli_query($bdd, $query);

        while($donnees = mysqli_fetch_array($result, MYSQLI_ASSOC))
        {
            $tableau[] = $donnees;
        }
        echo'<table class="tabprod"><tr>';
        foreach ($tableau as $tab){
            echo '<td style="border: solid black 1px; font-size: 10px;">'.$tab['libelle_article'].'</td>';
        }
        echo '</tr>';

        foreach ($tableau as $tab){
            $nomImg = $tab['libelle_article'];
            echo '<td style="border: solid black 1px;"><img style="width: 30px" src="../images/tabProd/'.$nomImg.'.jpg"></td>';
        }
        echo '</tr>';

        foreach ($tableau as $tab){
            $nomImg = $tab['prix_article'];
            echo '<td style="border: solid black 1px;">'.$tab['prix_article'].' €</td>';
        }

        echo'</tr></table>';
?>
    <br>
    <h2>Réserver un équipement</h2>
    <?php
        echo '<form method="post" action="reservation.php">
                <select name="combobox">';
            foreach ($tableau as $tab){
                echo '<option>'.$tab['libelle_article'].'</option>';
            }
            echo'</select>';
    ?>

    <br>

    <label for="nom">Nom et prénom :</label>
        <input type="text" class="form-control" id="nom" name="nom">

    <label for="email">Email :</label>
        <input type="email" class="form-control" id="email" name="mail">

    <label for="telephone">Téléphone :</label>
        <input type="tel" class="form-control" id="tel" name="tel">

    <br><br>

        <button type="submit" class="btn btn-info">Réserver</button>
    </form>

<?php include '../footer.php'; ?>