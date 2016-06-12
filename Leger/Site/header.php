<!DOCTYPE html>
<html lang="fr">
  <head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="description" content="Site appartenant à Para-vent, dans le but de présenter ces produits et services.">
    <link rel="icon" href="../images/logo-parapente.ico">

    <title><?PHP echo $title; ?> - Paravent</title>

    <link href="../css/bootstrap.min.css" rel="stylesheet">
    <link href="../css/carousel.css" rel="stylesheet">
    <link href="../css/style.css" rel="stylesheet">
  </head>
<!-- Barre de navigation -->
  <body>
    <div class="navbar-wrapper">
      <div class="container">
        <nav class="navbar navbar-inverse navbar-static-top">
          <div class="container">
            <div class="navbar-header">
              <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#navbar" aria-expanded="false" aria-controls="navbar">
                <span class="sr-only">Afficher la navigation</span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
              </button>
              <a class="logo navbar-brand" href="../accueil/"><img src="../images/logo-parapente.png" height="50" width="53"/></a>
              <a class="navbar-brand" href="../accueil/">Para-Vent</a>
            </div>
            <div id="navbar" class="navbar-collapse collapse">
              <ul class="nav navbar-nav">
                <li id="accueil"><a href="../accueil/">Accueil</a></li>

                <li class="dropdown">
                  <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">Formations <span class="caret"></span></a>
                  <ul class="dropdown-menu">
                    <li><a href="../formations/?id=1">Parachute</a></li>
                    <li role="separator" class="divider"></li>
                    <li><a href="../formations/?id=2">Parapente</a></li>
                    <li role="separator" class="divider"></li>
                    <li><a href="../formations/?id=3">Wingsuit</a></li>
                  </ul>
                </li>
                <li id="equipements"><a href="../equipements/">Équipements</a></li>
                <li id="a-propos"><a href="../a-propos/">À propos</a></li>
                <li id="contact"><a href="../nous-contacter/">Contact</a></li>
              </ul>
            </div>
          </div>
        </nav>

      </div>
    </div>


    <!-- Carrousel -->
    <div id="myCarousel" class="carousel slide" data-ride="carousel">
      <ol class="carousel-indicators">
        <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
        <li data-target="#myCarousel" data-slide-to="1"></li>
        <li data-target="#myCarousel" data-slide-to="2"></li>
      </ol>
      <div class="carousel-inner" role="listbox">
        <div class="item active">
          <img class="first-slide" src="../images/parapente-accueil1.jpg" height="2842" width="5500" alt="First slide">
          <div class="container">
            <div class="carousel-caption">
              <h1>Toute l'année !</h1>
              <p>Profitez de nos 5 centre de formations réparti dans toute la France pour faire un vol quand vous le souhaitez.</p>
              <p><a class="btn btn-lg btn-primary" href="../formations/?id=1" role="button">Réserver un vol</a></p>
            </div>
          </div>
        </div>
        <div class="item">
          <img class="second-slide" src="../images/parachute-acceuil2.jpg" alt="Second slide">
          <div class="container">
            <div class="carousel-caption">
              <h1>Une formation personnelle.</h1>
              <p>Nos formateurs vous accompagnent et vous apprennent à vous servir du matériel.</p>
              <p><a class="btn btn-lg btn-primary" href="../formations/?id=1" role="button">En savoir plus</a></p>
            </div>
          </div>
        </div>
        <div class="item">
          <img class="third-slide" src="../images/parachute-acceuil3.jpg" alt="Third slide">
          <div class="container">
            <div class="carousel-caption">
              <h1>Un simple saut ?</h1>
              <p>Si vous ne souhaitez pas suivre une formation, vous pouvez aussi profiter de l’option "saut touristique" pour un bol de plein air.</p>
              <p><a class="btn btn-lg btn-primary" href="../formations/?id=1" role="button">Réserver maintenant</a></p>
            </div>
          </div>
        </div>
      </div>
      <a class="left carousel-control" href="#myCarousel" role="button" data-slide="prev">
        <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
        <span class="sr-only">Précédente</span>
      </a>
      <a class="right carousel-control" href="#myCarousel" role="button" data-slide="next">
        <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
        <span class="sr-only">Suivante</span>
      </a>
    </div><!-- /.carrousel -->
<div class="container marketing">