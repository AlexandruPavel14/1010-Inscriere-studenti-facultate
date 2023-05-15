## **Aplicatie pentru inscrierea studentilor dintr-o facultate**

- Baza de date: Microsoft Access
- Interfata grafica: Windows Forms
- Limbaj de programare: C#
- IDE: Visual Studio 2019

### **Baza de date**
1. **Studenti**(IdStudent, NumeStudentCNP, NrTelefon, SpImagine)
2. **Specializari**(IdSpecializare, DenumireSpecializare, NrAniStudiu, TaxaAnuala)
3. **Inscrieri**(IdInscriere, DataInscrierii, IdSpecializare, TaxaAnuala, AnStudiu)
4. **InscrieriContinut**(IdInscriere, Nrc, IdStudent, TaxaInitiala)