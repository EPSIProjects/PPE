<?php $title="Formations"; 
$id=1;
?>
<?php include '../header.php'; ?>

<ul class="nav nav-tabs section">
  <li id="parachute1"><a data-toggle="tab" href="#parachute">Parachute</a></li>
  <li id="parapente1"><a data-toggle="tab" href="#parapente">Parapente</a></li>
  <li id="wingsuit1"><a data-toggle="tab" href="#wingsuit">Wingsuit</a></li>
</ul>

<div class="tab-content">
  <div id="parachute" class="tab-pane fade forma">

    <img class="imgentforma" src="../images/para2.jpg" height="200" width="200">
    <h3>Parachute</h3>
    <span class="reservform">
    <br>
    <p><h4>
    Le saut en parachute en tandem est idéal pour découvrir les sensations du parachutisme.<br>
    C’est aussi la façon la plus sécurisante de ressentir les premières émotions dans les airs.<br><br>
    Après une formation d’environ 10 minutes vous enseignant les rudiments de la position en chute libre, l’avion monte entre 3000 et 4000 mètres d’altitude. Soyez rassuré, vous êtes accroché à un moniteur. Laissez vous guider et profiter en toute sécurité d’environ 45 secondes de chute libre à plus de 200 kms/h et de 5 minutes de balade sous voile, avant l’atterrissage.<br><br>
Avec le baptême de parachutisme, vous découvrirez les sensations uniques de la chute libre et du pilotage de l’aile avec une seule envie : recommencer !<br>
    Le saut en parachute en tandem est accessible à tous à partir de 15 ans, avec dérogation possible à partir de 11 ans selon les zones de sauts.
    </h4></p><br>
    <img src="../images/tarifs.png">
    <br>
    <br>
    </span>
    <form action="../reserver/">
    <button type="submit" class="btn btn-warning">Réserver</button>
    </form>
  </div>
  <div id="parapente" class="tab-pane fade forma">
    <img class="imgentforma" src="../images/para1.jpg" height="200" width="200">
    <h3>Parapente</h3>
    <span class="reservform">
    <br>
    <p><h4>
    Venez découvrir les sensations d’un premier vol parapente en tandem avec un moniteur diplômé d’Etat qui vous transmettra les bases du vol libre. 800 mètres de dénivelé, environ 15 minutes de vol en fonction des conditions météo du jour, pour un souvenir impérissable.<br><br>

     Para-vent propose également des stages de perfectionnement en parapente qui vous permettront de faire du vol libre ou passer votre brevet de pilote de parapente , faire du speed riding, acheter votre matériel de vol, votre parapente, vos accessoires, sellettes, en neuf ou en occasion.
     </h4></p>
    <br>
    <img src="../images/tarifs.png">
    <br>
    <br>
    </span>
    <form action="../reserver/">
    <button type="submit" class="btn btn-success">Réserver</button>
    </form>
  </div>
  <div id="wingsuit" class="tab-pane fade forma">
    <img class="imgentforma" src="../images/wing1.jpg" height="200" width="200">
    <h3>Wingsuit</h3>
    <span class="reservform">
    <br>
    <p><h4>
    Nos instructeurs certifiés vous offre un cours d’initiation théorique d’une durée moyenne deux heures, portant sur les sorties d’avion, sur les techniques de vol et sur les points de sécurité. De plus, des vols de perfectionnement et d’entrainement sont également offerts aux sauteurs possédant déjà l’expérience en pilotage de wingsuit.<br><br>
    Vous devez posséder un brevet B et un minimum 200 sauts pour faire l’essai d’un wingsuit de formation débutant. Vous devez maitriser les différentes phases du parachutisme conventionnel (Faire seulement des sauts de track ne vous aidera pas a etre meilleur pour le wingsuit) et posséder une voilure stable et un altison. Contactez-nous pour plus de détails à ce sujet.
    </h4></p>
    <br>
    <img src="../images/tarifs_wingsuit.jpg">
    <br>
    <br>
    </span>
    <form action="../reserver/">
    <button type="submit" class="btn btn-info">Réserver</button>
    </form>
  </div>
</div>
<?php 
$id=$_GET['id'];
if ($id==1) {
  echo '
  <script type="text/javascript">
document.getElementById("parachute1").className = "active";
document.getElementById("parachute").className = "tab-pane fade forma active in";

</script>';
}
if ($id==2) {
  echo '
  <script type="text/javascript">
document.getElementById("parapente1").className = "active";
document.getElementById("parapente").className = "tab-pane fade forma active in";
</script>';
}
if ($id==3) {
  echo '
  <script type="text/javascript">
document.getElementById("wingsuit1").className = "active";
document.getElementById("wingsuit").className = "tab-pane fade forma active in";
</script>';
}
?>
<?php include '../footer.php'; ?>