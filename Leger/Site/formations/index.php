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
  <div id="parachute" class="tab-pane fade">
    <h3>Parachute</h3>
    <p>Some content.</p>
    <form action="../reserver/">
    <button type="submit" class="btn btn-warning">Réserver</button>
    </form>
  </div>
  <div id="parapente" class="tab-pane fade">
    <h3>Parapente</h3>
    <p>Some content in menu 1.</p>
    <form action="../reserver/">
    <button type="submit" class="btn btn-success">Réserver</button>
    </form>
  </div>
  <div id="wingsuit" class="tab-pane fade">
    <h3>Wingsuit</h3>
    <p>Some content in menu 2.</p>
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
document.getElementById("parachute").className = "tab-pane fade active in";

</script>';
}
if ($id==2) {
  echo '
  <script type="text/javascript">
document.getElementById("parapente1").className = "active";
document.getElementById("parapente").className = "tab-pane fade active in";
</script>';
}
if ($id==3) {
  echo '
  <script type="text/javascript">
document.getElementById("wingsuit1").className = "active";
document.getElementById("wingsuit").className = "tab-pane fade active in";
</script>';
}
?>
<?php include '../footer.php'; ?>