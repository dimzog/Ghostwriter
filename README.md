Τμήμα Πληροφορικής Σύγχρονα Θέματα Τεχνολογίας Λογισμικού Εργασία Παράδοση:
15 Ιανουαρίου 2019 Μια αλυσίδα βιβλιοπωλείων χρησιμοποιεί τη παρακάτω Βάση Δεδομένων σε Access για την οργάνωση των δεδομένων της.
Στα πλαίσια της μηχανογραφικής αναβάθμισης της, χρειάζεται την ανάπτυξη μιας δικτυακής εφαρμογής
για την καλύτερη αποτελεσματικότητα στην καταχώρηση και στη διαχείριση των δεδομένων της.
Να αναπτύξετε μια διαδικτυακή εφαρμογή σε Visual C# (ASP.NET Web Application)
χρησιμοποιώντας την αρχιτεκτονική σχεδίασης Model View Controller στο περιβάλλον ανάπτυξης Visual Studio.
Η εφαρμογή θα πρέπει να υλοποιεί τη παρακάτω λειτουργικότητα.
Διαχείριση των δεδομένων Τα δεδομένα της εταιρείας θα πρέπει να διαχειρίζονται πλήρως μέσα από τις αντίστοιχες φόρμες.

Η εφαρμογή θα πρέπει να διαχειρίζεται πλήρως (εισαγωγή, διαγραφή, επεξεργασία) τα δεδομένα όλων των πινάκων.
Δημιουργία αναφορών Πέρα από το διαχειριστικό κομμάτι, μέσω της εφαρμογής θα πρέπει να δίνονται απαντήσεις
στα παρακάτω ερωτήματα με τη δημιουργία των αντίστοιχων αναφορών: Ανέκτησε τα στοιχεία επικοινωνίας
των συγγραφέων που τα βιβλία τους είναι ανάμεσα σε X πρώτα σε πωλήσεις για συγκεκριμένο χρονικό διάστημα.

Ο χρήστης θα πρέπει να ορίζει τα εξής κριτήρια για την δημιουργία της αναφοράς:
Αριθμός Χ,
Χρονικό διάστημα Ημερομηνία Από – Έως.

Δημιούργησε μια αναφορά που θα δείχνει το Id της παραγγελίας (OrderID),
το κατάστημα στο οποίο έγινε η παραγγελία και ο τίτλος του βιβλίου που σχετίζεται με την αντίστοιχη παραγγελία.
Εμφάνισε εκείνες τις παραγγελίες που έγιναν (ordered) εντός ενός ημερολογιακού διαστήματος.
Ο χρήστης θα πρέπει να ορίζει τα εξής κριτήρια για την δημιουργία της αναφοράς:
Χρονικό διάστημα παραγγελιών Ημερομηνία Από - Έως, Επωνυμία καταστήματος Από - Έως (χρησιμοποιώντας τον τελεστή LIKE).

Προσοχή: Σε κάθε φόρμα αναφοράς που θα δημιουργήσετε, ο χρήστης μπορεί να αφήσει κενό ένα κριτήριο.
Τα κενά κριτήρια δεν λαμβάνονται υπόψιν στα ερωτήματα που θα χρειαστεί να κατασκευάσετε για την κατάρτιση των αναφορών.
Αν το επιθυμείτε, μπορείτε να δημιουργήσετε επιπλέον αναφορές χρησιμοποιώντας τα δεδομένα της εφαρμογής.
Διαχείριση αντιγράφων ασφαλείας μέσα από την εφαρμογή
Εξουσιοδοτημένος χρήστης (διαχειριστής) θα μπορεί μέσω της εφαρμογής να εκτελεί τις εξής διαχειριστικές λειτουργίες:
Διαδικασία δημιουργίας αντιγράφων ασφαλείας της Βάσης Δεδομένων σε κατάλογο που θα ορίζει.
Θα μπορεί να διαλέξει το είδος του backup (full, incremental). Διαδικασία restore από αντίγραφο ασφαλείας.
Ο διαχειριστής θα μπορεί να διαλέξει από ποιο backup data set θα γίνει το restore των δεδομένων.
Για το GUI της εφαρμογής να χρησιμοποιήσετε κλάσεις του bootstrap και να δώσετε έμφαση στη καλή εμφάνιση και διεπαφή με τον χρήστη.
Στα παραδοτέα της εργασίας θα πρέπει να συμπεριλάβετε ένα Τεχνικό Εγχειρίδιο όπου θα αναλύονται με
παραδείγματα ο τρόπος χρήσης των αντικειμένων της Βάσης Δεδομένων από το μοντέλο MVC ( views, models, controllers).

Επίσης θα πρέπει να συμπεριλάβετε ένα Εγχειρίδιο Χρήστη όπου θα παρουσιάζετε την εφαρμογή
και τις λειτουργίες της με παραδείγματα και screenshots από την εφαρμογή.