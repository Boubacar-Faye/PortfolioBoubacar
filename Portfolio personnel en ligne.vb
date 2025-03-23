<!DOCTYPE html>
<html lang="fr">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Portfolio - Boubacar</title>
    <link rel="stylesheet" href="styles.css">
    <script defer src="script.js"></script>
</head>
<body>
    <!-- Header avec fond noir -->
    <header id="header">
        <h1>Boubacar FAYE</h1>
        <nav>
            <ul>
                <li><a href="#about">À propos</a></li>
                <li><a href="#skills">Compétences</a></li>
                <li><a href="#projects">Projets</a></li>
                <li><a href="#contact">Contact</a></li>
            </ul>
        </nav>
    </header>

    <!-- Section "À propos" -->
    <section id="about" class="fade-in about-section">
        <div class="about-text">
            <h2>Je suis <span class="highlight">Boubacar FAYE</span>, Développeur en devenir passionné par le Web et le Design.</h2>
            <p>Je m'appelle Boubacar, passionné par la création de sites web modernes et interactifs.</p>
            <p>Je suis actuellement étudiant en développement web, et je cherche à améliorer mes compétences en JavaScript, HTML et CSS.</p>
            <p>J'adore transmettre mes idées en projets concrets et expérimenter avec les nouvelles technologies.</p>
            <a href="cv.pdf" class="cv-download">Télécharger mon CV</a>
        </div>
        <div class="about-photo">
            <img src="C:\Users\DELL\Desktop\Mon Portfolio\My profil.jpeg"
        </div>
    </section>

    <!-- Section "Mes projets" -->
    <section id="projects" class="fade-in projects-section">
        <h2>Projets</h2>
        <div class="projects">
            <div class="project-card">
                <h3>Mini-jeu interactif en Javascript</h3>
                <p>Un mini-jeu interactif en Javascript qui utilise des événements DOM.</p>
                <p>#html, #css, #js</p>
            </div>
            <div class="project-card">
                <h3>Mini-jeu interactif en Javascript</h3>
                <p>Un mini-jeu interactif en Javascript qui utilise des événements DOM.</p>
                <p>#html, #css, #js</p>
            </div>
            <div class="project-card">
                <h3>Mini-jeu interactif en Javascript</h3>
                <p>Un mini-jeu interactif en Javascript qui utilise des événements DOM.</p>
                <p>#html, #css, #js</p>
            </div>
        </div>
    </section>

    <!-- Section "Mes compétences" -->
    <section id="skills" class="fade-in skills-section">
        <h2>Compétences</h2>
        <div class="skills-container">
            <div class="soft-skills">
                <h3>Soft Skills</h3>
                <div class="skill">
                    <span>Gestion de projet</span>
                    <div class="progress-bar" style="width: 80%;"></div>
                </div>
                <div class="skill">
                    <span>Résolution de problème</span>
                    <div class="progress-bar" style="width: 70%;"></div>
                </div>
                <div class="skill">
                    <span>Adaptabilité</span>
                    <div class="progress-bar" style="width: 75%;"></div>
                </div>
            </div>

            <div class="hard-skills">
                <h3>Hard Skills</h3>
                <div class="skill">
                    <span>HTML</span>
                    <div class="progress-bar" style="width: 70%;"></div>
                </div>
                <div class="skill">
                    <span>CSS</span>
                    <div class="progress-bar" style="width: 65%;"></div>
                </div>
                <div class="skill">
                    <span>JavaScript</span>
                    <div class="progress-bar" style="width: 60%;"></div>
                </div>
                <div class="skill">
                    <span>VS Code</span>
                    <div class="progress-bar" style="width: 70%;"></div>
                </div>
            </div>
        </div>
    </section>

    <!-- Section "Vous avez un projet en tête ?" -->
    <section id="contact" class="fade-in contact-section">
        <h2>Vous avez un projet en tête ? N'hésitez pas à me contacter.</h2>
        <form id="contact-form">
            <label for="first-name">Votre prénom :</label>
            <input type="text" id="first-name" required>
            
            <label for="last-name">Votre nom :</label>
            <input type="text" id="last-name" required>
            
            <label for="subject">Votre sujet :</label>
            <input type="text" id="subject" required>
            
            <label for="message">Contenu du message :</label>
            <textarea id="message" required></textarea>
            
            <button type="submit">Envoyer</button>
        </form>
        <p id="form-message"></p>
    </section>

    <!-- Footer avec fond blanc -->
    <footer>
        <p>Designed by Boubacar FAYE with HTML, CSS, JS</p>
    </footer>

    <!-- Styles CSS -->
    <style>
        /* Entête avec fond noir */
        #header {
            position: sticky;
            top: 0;
            background-color: #000;
            color: white;
            padding: 10px 0;
            text-align: center;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
        }

        #header h1 {
            margin: 0;
            font-size: 2.5em;
            letter-spacing: 1px;
        }

        #header nav ul {
            list-style: none;
            padding: 0;
            margin: 0;
            display: flex;
            justify-content: center;
        }

        #header nav ul li {
            margin: 0 20px;
        }

        #header nav ul li a {
            color: white;
            text-decoration: none;
            font-weight: bold;
            font-size: 1.1em;
            position: relative;
            transition: color 0.3s ease;
        }

        #header nav ul li a:hover {
            color: #ffd700;
        }

        /* Section "À propos" */
        .about-section {
            background-color: #e0f7fa;
            display: flex;
            justify-content: space-between;
            padding: 40px;
        }

        .about-text {
            flex: 1;
            padding-right: 20px;
        }

        .about-photo {
            flex: 1;
            display: flex;
            justify-content: center;
            align-items: center;
        }

        .about-photo img {
            width: 200px; /* Taille augmentée de l'image */
            height: 200px;
            border-radius: 50%; /* Image arrondie en cercle */
        }

        .cv-download {
            color: #32CD32;
            text-decoration: none;
            font-weight: bold;
        }

        /* Section "Projets" */
        .projects-section {
            background-color: #f4f4f4;
            padding: 40px;
        }

        .projects {
            display: flex;
            justify-content: space-around;
            margin-top: 20px;
        }

        .project-card {
            background-color: white;
            padding: 20px;
            border-radius: 10px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            text-align: center;
            width: 30%;
        }

        .project-card h3 {
            color: #32CD32;
        }

        /* Section "Compétences" */
        .skills-section {
            background-color: #ffffff;
            padding: 40px;
        }

        .skills-container {
            display: flex;
            justify-content: space-between;
        }

        .soft-skills, .hard-skills {
            width: 48%;
        }

        .skill {
            margin: 10px 0;
        }

        .progress-bar {
            height: 5px;
            background-color: #32CD32;
            border-radius: 5px;
            margin-top: 5px;
        }

        /* Section "Contact" */
        .contact-section {
            background-color: #333;
            color: white;
            padding: 40px;
            text-align: center;
        }

        .contact-section input, .contact-section textarea {
            width: 100%;
            padding: 10px;
            margin: 5px 0;
            border-radius: 5px;
            border: 1px solid #ccc;
        }

        .contact-section button {
            background-color: #32CD32;
            color: white;
            padding: 10px 20px;
            border: none;
            border-radius: 5px;
            cursor: pointer;
            transition: background-color 0.3s ease;
        }

        .contact-section button:hover {
            background-color: #28a745;
        }

        footer {
            background-color: white; /* Fond du footer blanc */
            color: #000;
            padding: 10px;
            text-align: center;
        }

        footer p {
            margin: 0;
        }
    </style>

    <!-- Script JS -->
    <script>
        document.getElementById('contact-form').addEventListener('submit', function(event) {
            event.preventDefault();

            const firstName = document.getElementById('first-name').value;
            const lastName = document.getElementById('last-name').value;
            const subject = document.getElementById('subject').value;
            const message = document.getElementById('message').value;

            if (firstName && lastName && subject && message) {
                document.getElementById('form-message').innerText = "Merci pour votre message, je reviendrai vers vous bientôt !";
                this.reset();
            } else {
                document.getElementById('form-message').innerText = "Veuillez remplir tous les champs.";
            }
        });
    </script>
</body>
</html>
