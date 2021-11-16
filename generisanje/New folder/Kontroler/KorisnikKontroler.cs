/***********************************************************************
 * Module:  KorisnikKontroler.cs
 * Author:  mihaj
 * Purpose: Definition of the Interface Kontroler.KorisnikKontroler
 ***********************************************************************/

using System;

namespace Kontroler
{
   public interface KorisnikKontroler
   {
      Object PrijavljivanjeKorisnika(String korisnickoIme, String lozinka);
      bool IzmenaLozinke(String staraLozinka, String novaLozinka);
      bool IzmenaKorisnickogImena(String staroKorisnickoIme, String novoKorisnickoIme);
   }
}