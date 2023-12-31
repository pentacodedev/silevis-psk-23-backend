﻿using HTMLQuestPDF.Extensions;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using HackathonApi.Entities;
using SkiaSharp;
using HackathonApi.DTOs;


namespace HackathonApi;
public class PDFservice
{

	public PDFservice() { }

	public string Replace(string form, User student, InternshipDTO internship)
	{
		form = form.Replace("#1", DateTime.Now.ToString("dd.MM.yyyy"));
		form = form.Replace("#2", internship.CompanyName);
		form = form.Replace("#3", internship.CompanyAddress);
		form = form.Replace("#4", internship.CompanyKrsNumber);
		form = form.Replace("#5", internship.CompanyNipNumber);
		form = form.Replace("#6", internship.CompanyRegonNumber);
		form = form.Replace("#7", internship.CompanyRepresentativeFirstname + " " + internship.CompanyRepresentativeSurname);
		form = form.Replace("#8", student.FirstName);
		form = form.Replace("#9", student.LastName);
		form = form.Replace("#10", student.StudentNumber.ToString());
		form = form.Replace("#11", internship.DateOfStart.ToString("dd.mm"));
		form = form.Replace("#12", internship.DateOfEnd.ToString("dd.mm"));

		return form;
	}

	public byte[] Form_1_Generate(User student, InternshipDTO internship, bool polish)
	{
		string form = " ";

		if (polish)
			form = File.ReadAllText("Forms_templ/Form_Pol_1.txt");
        else
			form = File.ReadAllText("Forms_templ/Form_Eng_1.txt");

		form = Replace(form, student, internship);

		return Document.Create(container =>
		{
			container.Page(page =>
			{
				page.Size(PageSizes.A4);
				page.MarginLeft(2.5f, Unit.Centimetre);
				page.MarginRight(2.5f, Unit.Centimetre);
				page.MarginBottom(1.26f, Unit.Centimetre);
				page.MarginTop(2.56f, Unit.Centimetre);
				page.PageColor(Colors.White);


				page.DefaultTextStyle(TextStyle.Default.FontFamily("Times New Roman"));

				page.Content().Column(col =>
				{
					col.Item().HTML(handler =>
					{
						handler.SetContainerStyleForHtmlElement("div", c => c.ContentFromRightToLeft());
						handler.SetContainerStyleForHtmlElement("container", c => c.AlignCenter());


						handler.SetHtml(form);

					});
				});
			});

			container.Page(page =>
			{
				page.Size(PageSizes.A4);
				page.MarginLeft(2.5f, Unit.Centimetre);
				page.MarginRight(2.5f, Unit.Centimetre);
				page.MarginBottom(1.26f, Unit.Centimetre);
				page.MarginTop(2.56f, Unit.Centimetre);
				page.PageColor(Colors.White);


				page.DefaultTextStyle(TextStyle.Default.FontFamily("Times New Roman"));

				page.Content().Column(col =>
				{
					col.Item().HTML(handler =>
					{
						handler.SetContainerStyleForHtmlElement("div", c => c.ContentFromRightToLeft());
						handler.SetContainerStyleForHtmlElement("container", c => c.AlignCenter());
						handler.SetContainerStyleForHtmlElement("table", c => c.BorderColor(Colors.White));




						handler.SetHtml(@"<p><b>§ 5. 1</b>Strony wyznaczają osoby właściwe do kontaktu w bieżących sprawach:</p>
                                        <p><b>1)</b> z ramienia Zakładu Pracy <h7>" + internship.CompanyRepresentativeFirstname + " " + internship.CompanyRepresentativeSurname + "</h7><br>" +
										"tel.: <h7>" + internship.CompanyPhoneNumber + "</h7><br>" +
										"e-mail: <h7>" + internship.CompanyEmail + "</h7><br>" +
										"<b>2)</b> z ramienia Uczelni <h7>Patryk Frączek</h7><br>" +
										"tel.: <h7>123 123 123</h7><br>" +
										"e-mail: <h7>p.fraczek@tu.kiece.pl</h7></p>" +
										"<p><b>2.</b> Klauzula informacyjna dotycząca przetwarzania przez Uczelnię danych osobowych " +
										"pozyskanych z Zakładu stanowi załącznik nr 2 do niniejszej umowy. Zakład zobowiązuje się do" +
										" udostępnienia załącznika osobom, których dane przekazano na podstawie niniejszej umowy. <br>" +
										"<b>§ 6.</b> Umowa niniejsza została sporządzona w dwóch jednobrzmiących egzemplarzach po jednym dla każdej ze Stron.<br>" +
										"<b>§ 7.</b> Ewentualne spory mogące wyniknąć na tle stosowania niniejszej umowy będą rozstrzygane na zasadzie " +
										"mediacji przez wytypowanych przez każdą ze Stron mediatorów.<br>  " +
										"<b>§ 8.</b> Umowa została zawarta na czas odbywania przez studenta praktyki określony w § 1. <br><br>" +
										"<br><b>W imienu zakładu:</b> <b> &nbsp;  &nbsp;  &nbsp;  &nbsp;  W imieniu Politechniki Świętokrzyskiej:</b><br><br><br><br>" +
										"<br>.................................................................................................................<br>" +
										"");

					});
				});
			});
		})
		 .GeneratePdf();
	}

	public byte[] Form_2_Generate(User student, InternshipDTO internship, bool polish)
	{
		string form = " ";

		if (polish)
			form = File.ReadAllText("Forms_templ/Form_Pol_2.txt");
		else
			form = File.ReadAllText("Forms_templ/Form_Eng_2.txt");

		form = Replace(form, student, internship);

		return Document.Create(container =>
		{
			container.Page(page =>
			{
				page.Size(PageSizes.A4);
				page.MarginLeft(2.5f, Unit.Centimetre);
				page.MarginRight(2.5f, Unit.Centimetre);
				page.MarginBottom(1.26f, Unit.Centimetre);
				page.MarginTop(2.56f, Unit.Centimetre);
				page.PageColor(Colors.White);


				page.DefaultTextStyle(TextStyle.Default.FontFamily("Times New Roman"));

				page.Content().Column(col =>
				{
					col.Item().HTML(handler =>
					{
						handler.SetContainerStyleForHtmlElement("div", c => c.ContentFromRightToLeft());
						handler.SetContainerStyleForHtmlElement("container", c => c.AlignCenter());
						handler.SetContainerStyleForHtmlElement("aside", c => c.AlignLeft());


						handler.SetHtml(form);

					});
				});

			});

			container.Page(page =>
			{
				page.Size(PageSizes.A4);
				page.MarginLeft(2.5f, Unit.Centimetre);
				page.MarginRight(2.5f, Unit.Centimetre);
				page.MarginBottom(1.26f, Unit.Centimetre);
				page.MarginTop(2.56f, Unit.Centimetre);
				page.PageColor(Colors.White);


				page.DefaultTextStyle(TextStyle.Default.FontFamily("Times New Roman"));

				page.Content().Column(col =>
				{
					col.Item().HTML(handler =>
					{
						handler.SetContainerStyleForHtmlElement("div", c => c.ContentFromRightToLeft());
						handler.SetContainerStyleForHtmlElement("container", c => c.AlignCenter());


						handler.SetHtml(@"<div><p><b>Załącznik A</b><br></p></div>
                                       
                                       <container><h5>Zaświadczenie</h5></container>
                                      <p><b>1. Cel wystawienia: </b>zaliczenie praktyki studenckiej<br>
                                         <b>2. Imię i nazwisko studenta:</b>  " + student.FirstName + " " + student.LastName + @"<br>
                                      <b>3. Nazwa instytucji/zakładu, w której pracuje/pracował student:</b><br>
                                      <b>4. Adres instytucji/zakładu</b><br>
                                     <b>4. Adres instytucji/zakładu</b><br>
                                     <b>7. Czas pracy</b><br>
                                     <b>8. Zakres obowiązków studenta w czasie pracy w odniesieniu do kierunku jego studiów</b><br>
                                     <b>9. Dane osoby, która może poświadczyć prawdziwość powyższych danych (prezes, dyrektor,Koordynator Programu Badawczego/Erasmusa, itp.) wraz z podpisem</b><br>
                                     <b>10. Uwagi…</b><br>
                                     <b>11. Data i podpis studenta</b><br>
                                         </p>");

					});
				});

			});


		})
		 .GeneratePdf();
	}
}




