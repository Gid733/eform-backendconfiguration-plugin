/*
The MIT License (MIT)

Copyright (c) 2007 - 2021 Microting A/S

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

namespace BackendConfiguration.Pn.Infrastructure.Data.Seed.Data
{
    using System.Collections.Generic;

    public static class BackendConfigurationSeedEforms
    {
        public static IEnumerable<string> EformsSeed => new[]
        {
@"<?xml version=""1.0"" encoding=""UTF-8""?>
<Main>
	<Id>142244</Id>
	<Repeated>0</Repeated>
	<Label>01. Elforbrug|01. Electricity||01. Електрика</Label>
	<StartDate>2021-01-11</StartDate>
	<EndDate>2031-01-11</EndDate>
	<Language>da</Language>
	<MultiApproval>false</MultiApproval>
	<FastNavigation>false</FastNavigation>
	<Review>false</Review>
	<Summary>false</Summary>
	<DisplayOrder>0</DisplayOrder>
	<ElementList>
		<Element type=""DataElement"">
			<Id>142244</Id>
			<Label>01. Elforbrug|01. Electricity||01. Електрика</Label>
			<Description>
				<![CDATA[Aflæs elmåler|Read electricity meter||Зчитування показань лічильника електроенергії]]>
			</Description>
			<DisplayOrder>0</DisplayOrder>
			<ReviewEnabled>false</ReviewEnabled>
			<ManualSync>false</ManualSync>
			<ExtraFieldsEnabled>false</ExtraFieldsEnabled>
			<DoneButtonDisabled>true</DoneButtonDisabled>
			<ApprovalEnabled>false</ApprovalEnabled>
			<DataItemGroupList>
				<DataItemGroup type=""FieldGroup"">
					<Id>372408</Id>
					<Label>LÆS MERE|READ MORE||ДОКЛАДНО</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>0</DisplayOrder>
					<Value>Closed</Value>
					<Color>fff6df</Color>
					<DataItemList>
						<DataItem type=""None"">
							<Id>372409</Id>
							<Label>INFO|INFO||ІНФОРМАЦІЯ</Label>
							<Description>
								<![CDATA[Eksempler på energibesparende foranstaltninger:<br>• Frekvensstyrede elmotorer til dele af staldriften, herunder ventilationen.<br>• Staldbelysning er kun tændt efter behov.<br>• Temperaturreguleret styringssystem til ventilation som sikrer, at ventilationen kører optimalt i forhold til staldtemperatur og elforbruget. Dette sikrer temperaturstyring og minimumsventilation i perioder hvor behovet for ventilation er lavt.<br>• Isolere bygninger, installere energibesparende belysning og anvende naturlig ventilation i videst muligt omfang.<br>|<br>Examples of energy saving measures:<br>• Frequency-controlled electric motors for parts of stable operation, including ventilation.<br>• Stable lighting is only switched on as needed.<br>• Temperature-controlled control system for ventilation which ensures that the ventilation runs optimally in relation to barn temperature and electricity consumption. This ensures temperature control and minimum ventilation during periods when the need for ventilation is low.<br>• Insulate buildings, install energy-saving lighting and use natural ventilation as much as possible.||< br>Приклади заходів з енергозбереження:<br> • Електродвигуни з частотним управлінням для частин стабільної роботи, включаючи вентиляцію.< br> • Стабільне освітлення включається тільки в міру необхідності.<br> • Система управління вентиляцією з регульованою температурою, яка забезпечує оптимальну роботу вентиляції в залежності від температури в коморі та споживання електроенергії. Це забезпечує контроль температури і мінімальну вентиляцію в періоди, коли потреба в вентиляції невелика.< br>• Ізолюйте будівлі, встановіть Енергозберігаюче освітлення і максимально використовуйте природну вентиляцію.]]>
							</Description>
							<DisplayOrder>0</DisplayOrder>
							<Color>fff6df</Color>
						</DataItem>
					</DataItemList>
				</DataItemGroup>
			</DataItemGroupList>
			<DataItemList>
				<DataItem type=""Number"">
					<Id>372407</Id>
					<Label>Elmåler (kWh)|Electricity meter (kWh)||Лічильник електроенергії (кВт * год)</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>1</DisplayOrder>
					<Mandatory>false</Mandatory>
					<MinValue/>
					<MaxValue/>
					<Value/>
					<DecimalCount/>
					<UnitName/>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Picture"">
					<Id>372405</Id>
					<Label>Billede|Picture||Зображення</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>3</DisplayOrder>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Comment"">
					<Id>372404</Id>
					<Label>Kommentar|Comment||Коментар</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>4</DisplayOrder>
					<Multi>1</Multi>
					<GeolocationEnabled>false</GeolocationEnabled>
					<Split>false</Split>
					<Value/>
					<ReadOnly>false</ReadOnly>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""SaveButton"">
					<Id>372406</Id>
					<Label>Gem registrering|Save registration||Зберегти реєстрацію</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>5</DisplayOrder>
					<Value>GEM|SAVE||ЗБЕРЕГТИ</Value>
					<Color>f0f8db</Color>
				</DataItem>
			</DataItemList>
		</Element>
	</ElementList>
</Main>",
@"<?xml version=""1.0"" encoding=""UTF-8""?>
<Main>
	<Id>142242</Id>
	<Repeated>0</Repeated>
	<Label>01. Vandforbrug|01. Water comsumption||01. Споживання води</Label>
	<StartDate>2021-01-11</StartDate>
	<EndDate>2031-01-11</EndDate>
	<Language>da</Language>
	<MultiApproval>false</MultiApproval>
	<FastNavigation>false</FastNavigation>
	<Review>false</Review>
	<Summary>false</Summary>
	<DisplayOrder>0</DisplayOrder>
	<ElementList>
		<Element type=""DataElement"">
			<Id>142242</Id>
			<Label>01. Vandforbrug|01. Water comsumption||01. Споживання води</Label>
			<Description>
				<![CDATA[Aflæs vandmåler|Read water meter||Зчитування показань лічильника води]]>
			</Description>
			<DisplayOrder>0</DisplayOrder>
			<ReviewEnabled>false</ReviewEnabled>
			<ManualSync>false</ManualSync>
			<ExtraFieldsEnabled>false</ExtraFieldsEnabled>
			<DoneButtonDisabled>true</DoneButtonDisabled>
			<ApprovalEnabled>false</ApprovalEnabled>
			<DataItemGroupList>
				<DataItemGroup type=""FieldGroup"">
					<Id>372393</Id>
					<Label>LÆS MERE|READ MORE||ДОКЛАДНО</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>0</DisplayOrder>
					<Value>Closed</Value>
					<Color>fff6df</Color>
					<DataItemList>
						<DataItem type=""None"">
							<Id>372394</Id>
							<Label>INFO|INFO||ІНФОРМАЦІЯ</Label>
							<Description>
								<![CDATA[Eksempler på vandbesparende foranstaltninger:<br>• Ved rengøring af staldene i blødsættes staldene forud for egentlig vask med højtryksrenser. Både i blødsætning og højtryksrensning er vandbesparende.<br>• Staldene kontrolleres dagligt og ved evt. lækager udføres der straks små reparationer eller der tilkaldes service, hvis der er behov for dette.<br>• Løbende kalibrering af drikkevandsinstallationerne.<br>|<br>Examples of water saving measures:<br>• When cleaning the stables, the stables are soaked prior to actual washing with a high-pressure cleaner. Soaking the stables and high pressure cleaning are water saving.<br>• The stables are checked daily and in the event of any leaks, small repairs are carried out immediately or service is called in if necessary.<br>• Continuous calibration of the drinking water installations.||<br>Приклади заходів з економії води:<br>• При збиранні стаєнь перед фактичним промиванням стайні промивають очищувачем високого тиску. Замочування стаєнь і очищення під високим тиском - це економія води.<br>• Стайні перевіряються щодня, і в разі будь-яких витоків негайно проводиться дрібний ремонт або при необхідності викликається служба.<br>• Безперервне калібрування установок для питної води.]]>
							</Description>
							<DisplayOrder>0</DisplayOrder>
							<Color>fff6df</Color>
						</DataItem>
					</DataItemList>
				</DataItemGroup>
			</DataItemGroupList>
			<DataItemList>
				<DataItem type=""Number"">
					<Id>372392</Id>
					<Label>Vandmåler (m3)|Water meter (m3)||Лічильник води (м3)</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>1</DisplayOrder>
					<Mandatory>false</Mandatory>
					<MinValue/>
					<MaxValue/>
					<Value/>
					<DecimalCount/>
					<UnitName/>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Picture"">
					<Id>372390</Id>
					<Label>Billede|Picture||Зображення</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>3</DisplayOrder>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Comment"">
					<Id>372389</Id>
					<Label>Kommentar|Comment||Коментар</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>4</DisplayOrder>
					<Multi>1</Multi>
					<GeolocationEnabled>false</GeolocationEnabled>
					<Split>false</Split>
					<Value/>
					<ReadOnly>false</ReadOnly>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""SaveButton"">
					<Id>372391</Id>
					<Label>Gem registrering|Save registration||Зберегти реєстрацію</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>5</DisplayOrder>
					<Value>GEM|SAVE||ЗБЕРЕГТИ</Value>
					<Color>f0f8db</Color>
				</DataItem>
			</DataItemList>
		</Element>
	</ElementList>
</Main>",
@"<?xml version=""1.0"" encoding=""UTF-8""?>
<Main>
	<Id>142266</Id>
	<Repeated>0</Repeated>
	<Label>02. Brandudstyr|02. Fire equipment||02. Пожежне обладнання</Label>
	<StartDate>2021-01-17</StartDate>
	<EndDate>2031-01-17</EndDate>
	<Language>da</Language>
	<MultiApproval>false</MultiApproval>
	<FastNavigation>false</FastNavigation>
	<Review>false</Review>
	<Summary>false</Summary>
	<DisplayOrder>0</DisplayOrder>
	<ElementList>
		<Element type=""DataElement"">
			<Id>142266</Id>
			<Label>02. Brandudstyr|02. Fire equipment||02. Пожежне обладнання</Label>
			<Description>
				<![CDATA[Kontrolpunkter brandudstyr|Checkpoints fire equipment||Контроль пожежної техніки]]>
			</Description>
			<DisplayOrder>0</DisplayOrder>
			<ReviewEnabled>false</ReviewEnabled>
			<ManualSync>false</ManualSync>
			<ExtraFieldsEnabled>false</ExtraFieldsEnabled>
			<DoneButtonDisabled>true</DoneButtonDisabled>
			<ApprovalEnabled>false</ApprovalEnabled>
			<DataItemGroupList>
				<DataItemGroup type=""FieldGroup"">
					<Id>372552</Id>
					<Label>LÆS MERE|READ MORE||ДОКЛАДНО</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>0</DisplayOrder>
					<Value>Closed</Value>
					<Color>fff6df</Color>
					<DataItemList>
						<DataItem type=""None"">
							<Id>372553</Id>
							<Label>INFO|INFO||ІНФОРМАЦІЯ</Label>
							<Description>
								<![CDATA[Alle skal vide, hvor brandudstyret er placeret, og hvordan det håndteres.<br><br>Der skal løbende foretages en kontrol og vedligeholdelse af brandudstyret, så det altid er funktionsdygtigt.&nbsp;<br>|<br>Everyone needs to know where the fire equipment is located and how it is handled.<br><br>The fire equipment must be checked and maintained on an ongoing basis so that it is always functional.||<br> Кожен повинен знати, де знаходиться пожежне обладнання і як з ним поводитися.<br> < br> Пожежне обладнання повинно перевірятися і обслуговуватися на постійній основі, щоб воно завжди функціонувало.]]>
							</Description>
							<DisplayOrder>0</DisplayOrder>
							<Color>fff6df</Color>
						</DataItem>
					</DataItemList>
				</DataItemGroup>
			</DataItemGroupList>
			<DataItemList>
				<DataItem type=""CheckBox"">
					<Id>372551</Id>
					<Label>Medarbejder kender placering af brandudstyr|Employee knows the location of fire equipment||Співробітник знає розташування пожежної техніки</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>1</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>372554</Id>
					<Label>Relvant brandudstyr til rådighed|Relevant fire equipment available||Є відповідне пожежне обладнання</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>2</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>372555</Id>
					<Label>Brandudstyr er ikke udløbet|Fire equipment has not expired||Термін придатності протипожежного обладнання не закінчився</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>4</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Picture"">
					<Id>372549</Id>
					<Label>Billede|Picture||Зображення</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>5</DisplayOrder>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Comment"">
					<Id>372548</Id>
					<Label>Kommentar|Comment||Коментар</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>6</DisplayOrder>
					<Multi>1</Multi>
					<GeolocationEnabled>false</GeolocationEnabled>
					<Split>false</Split>
					<Value/>
					<ReadOnly>false</ReadOnly>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""SaveButton"">
					<Id>372550</Id>
					<Label>Gem registrering|Save registration||Зберегти реєстрацію</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>7</DisplayOrder>
					<Value>GEM|SAVE||ЗБЕРЕГТИ</Value>
					<Color>f0f8db</Color>
				</DataItem>
			</DataItemList>
		</Element>
	</ElementList>
</Main>",
@"<?xml version=""1.0"" encoding=""UTF-8""?>
<Main>
	<Id>142269</Id>
	<Repeated>0</Repeated>
	<Label>02. Førstehjælp|02. First aid||02. Перша медична допомога</Label>
	<StartDate>2021-01-17</StartDate>
	<EndDate>2031-01-17</EndDate>
	<Language>da</Language>
	<MultiApproval>false</MultiApproval>
	<FastNavigation>false</FastNavigation>
	<Review>false</Review>
	<Summary>false</Summary>
	<DisplayOrder>0</DisplayOrder>
	<ElementList>
		<Element type=""DataElement"">
			<Id>142269</Id>
			<Label>02. Førstehjælp|02. First aid||02. Перша медична допомога</Label>
			<Description>
				<![CDATA[Kontrolpunkter for førstehjælpsudstyr|Checkpoint first aid equipment||Обладнання для надання першої допомоги на контрольно-пропускному пункті]]>
			</Description>
			<DisplayOrder>0</DisplayOrder>
			<ReviewEnabled>false</ReviewEnabled>
			<ManualSync>false</ManualSync>
			<ExtraFieldsEnabled>false</ExtraFieldsEnabled>
			<DoneButtonDisabled>true</DoneButtonDisabled>
			<ApprovalEnabled>false</ApprovalEnabled>
			<DataItemGroupList>
				<DataItemGroup type=""FieldGroup"">
					<Id>372576</Id>
					<Label>LÆS MERE|READ MORE||ДОКЛАДНО</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>0</DisplayOrder>
					<Value>Closed</Value>
					<Color>fff6df</Color>
					<DataItemList>
						<DataItem type=""None"">
							<Id>372577</Id>
							<Label>INFO|INFO</Label>
							<Description>
								<![CDATA[Det er ikke et lovkrav – men det anbefales, at alle ved, hvor førstehjælpskassen er placeret.<br>|<br>It is not a legal requirement - but it is recommended that everyone knows where the first aid kit is located.||<br> Це не є законною вимогою, але рекомендується, щоб всі знали, де знаходиться аптечка першої допомоги.]]>
							</Description>
							<DisplayOrder>0</DisplayOrder>
							<Color>fff6df</Color>
						</DataItem>
					</DataItemList>
				</DataItemGroup>
			</DataItemGroupList>
			<DataItemList>
				<DataItem type=""CheckBox"">
					<Id>372575</Id>
					<Label>Mængde af førstehjælpsudstyr OK|Amount of first aid equipment OK||Кількість першої допомоги в порядку</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>1</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>372578</Id>
					<Label>Medarbejder kender placering af førstehjælpskasse|Employee knows the location of the first aid kit||Співробітник знає, де знаходиться аптечка першої допомоги</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>2</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Picture"">
					<Id>372573</Id>
					<Label>Billede|Picture||Зображення</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>5</DisplayOrder>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Comment"">
					<Id>372572</Id>
					<Label>Kommentar|Comment||Коментар</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>6</DisplayOrder>
					<Multi>1</Multi>
					<GeolocationEnabled>false</GeolocationEnabled>
					<Split>false</Split>
					<Value/>
					<ReadOnly>false</ReadOnly>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""SaveButton"">
					<Id>372574</Id>
					<Label>Gem registrering|Save registration||Зберегти реєстрацію</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>7</DisplayOrder>
					<Value>GEM|SAVE||ЗБЕРЕГТИ</Value>
					<Color>f0f8db</Color>
				</DataItem>
			</DataItemList>
		</Element>
	</ElementList>
</Main>",
@"<?xml version=""1.0"" encoding=""UTF-8""?>
<Main>
	<Id>142267</Id>
	<Repeated>0</Repeated>
	<Label>02. Sikkerhedsudstyr_værnemidler|02. Safety equipment_protective equipment||02. Захисне обладнання_засоби захисту</Label>
	<StartDate>2021-01-17</StartDate>
	<EndDate>2031-01-17</EndDate>
	<Language>da</Language>
	<MultiApproval>false</MultiApproval>
	<FastNavigation>false</FastNavigation>
	<Review>false</Review>
	<Summary>false</Summary>
	<DisplayOrder>0</DisplayOrder>
	<ElementList>
		<Element type=""DataElement"">
			<Id>142267</Id>
			<Label>02. Sikkerhedsudstyr_værnemidler|02. Safety equipment_protective equipment||02. Захисне обладнання_засоби захисту</Label>
			<Description>
				<![CDATA[Kontrolpunkter sikkerhedsudstyr/værnemidler|Checkpoints safety equipment/protective equipment||Контроль обладнання для забезпечення безпеки/захисне спорядження]]>
			</Description>
			<DisplayOrder>0</DisplayOrder>
			<ReviewEnabled>false</ReviewEnabled>
			<ManualSync>false</ManualSync>
			<ExtraFieldsEnabled>false</ExtraFieldsEnabled>
			<DoneButtonDisabled>true</DoneButtonDisabled>
			<ApprovalEnabled>false</ApprovalEnabled>
			<DataItemGroupList>
				<DataItemGroup type=""FieldGroup"">
					<Id>372560</Id>
					<Label>LÆS MERE|READ MORE||ДОКЛАДНО</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>0</DisplayOrder>
					<Value>Closed</Value>
					<Color>fff6df</Color>
					<DataItemList>
						<DataItem type=""None"">
							<Id>372561</Id>
							<Label>INFO|INFO||ІНФОРМАЦІЯ</Label>
							<Description>
								<![CDATA[For at minimere arbejdsulykker og andre skadelige virkninger på miljøet, skal der være opsat værnemidler på husdyrbruget.<br><br>Forskellige arbejdsopgaver kræver forskellige værnemidler, og alle medarbejderne skal være bekendte med disse.<br>|<br>In order to minimize accidents at work and other harmful effects on the environment, protective equipment must be installed on livestock farms.<br><br>Different work tasks require different protective equipment, and all employees must be familiar with these.||<br> Для мінімізації нещасних випадків на виробництві та інших шкідливих впливів на навколишнє середовище на тваринницьких фермах необхідно встановлювати захисні засоби.<br><br>для виконання різних робочих завдань потрібні різні засоби захисту, і всі співробітники повинні бути знайомі з ними.]]>
							</Description>
							<DisplayOrder>0</DisplayOrder>
							<Color>fff6df</Color>
						</DataItem>
					</DataItemList>
				</DataItemGroup>
			</DataItemGroupList>
			<DataItemList>
				<DataItem type=""CheckBox"">
					<Id>372559</Id>
					<Label>Relevante værnemidler til rådighed|Relevant protective equipment available||Є відповідне захисне обладнання</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>1</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>372562</Id>
					<Label>Medarbejder ved hvor værnemidler findes|Employee knows where protective equipment is available||Співробітник знає, де доступні захисні засоби</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>2</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>372563</Id>
					<Label>Medarbejder er bekendt med korrekt brug af værnemidler|Employee is familiar with the correct use of protective equipment||Співробітник знайомий з правильним використанням захисних засобів</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>4</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Picture"">
					<Id>372557</Id>
					<Label>Billede|Picture||Зображення</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>5</DisplayOrder>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Comment"">
					<Id>372556</Id>
					<Label>Kommentar|Comment||Коментар</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>6</DisplayOrder>
					<Multi>1</Multi>
					<GeolocationEnabled>false</GeolocationEnabled>
					<Split>false</Split>
					<Value/>
					<ReadOnly>false</ReadOnly>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""SaveButton"">
					<Id>372558</Id>
					<Label>Gem registrering|Save registration||Зберегти реєстрацію</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>7</DisplayOrder>
					<Value>GEM|SAVE||ЗБЕРЕГТИ</Value>
					<Color>f0f8db</Color>
				</DataItem>
			</DataItemList>
		</Element>
	</ElementList>
</Main>",
@"<?xml version=""1.0"" encoding=""UTF-8""?>
<Main>
	<Id>142142</Id>
	<Repeated>0</Repeated>
	<Label>03. Kontrol flydelag|03. Control floating layer||03. Контроль плаваючого шару</Label>
	<StartDate>2020-10-06</StartDate>
	<EndDate>2030-10-06</EndDate>
	<Language>da</Language>
	<MultiApproval>false</MultiApproval>
	<FastNavigation>false</FastNavigation>
	<Review>false</Review>
	<Summary>false</Summary>
	<DisplayOrder>0</DisplayOrder>
	<ElementList>
		<Element type=""DataElement"">
			<Id>142142</Id>
			<Label>03. Kontrol flydelag|03. Control floating layer||03. Контроль плаваючого шару</Label>
			<Description>
				<![CDATA[Kontrollér flydelag og angiv evt. årsag til manglende flydelag.|Check floating layer and indicate - if necessary - cause of lack of floating layer.<br>||Перевірте плаваючий шар і вкажіть - при необхідності-причину відсутності плаваючого шару.<br>]]>
			</Description>
			<DisplayOrder>0</DisplayOrder>
			<ReviewEnabled>false</ReviewEnabled>
			<ManualSync>false</ManualSync>
			<ExtraFieldsEnabled>false</ExtraFieldsEnabled>
			<DoneButtonDisabled>true</DoneButtonDisabled>
			<ApprovalEnabled>false</ApprovalEnabled>
			<DataItemGroupList>
				<DataItemGroup type=""FieldGroup"">
					<Id>372222</Id>
					<Label>LÆS MERE|READ MORE||ДОКЛАДНО</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>0</DisplayOrder>
					<Value>Closed</Value>
					<Color>fff6df</Color>
					<DataItemList>
						<DataItem type=""None"">
							<Id>372223</Id>
							<Label>INFO|INFO||ІНФОРМАЦІЯ</Label>
							<Description>
								<![CDATA[Hvis der ikke er fast overdækning på en gyllebeholder, skal der etableres flydelag på gylleoverfladen.&nbsp;<br><br>Det skal altid sikres, at der er et tæt flydelag. Flydelaget begrænser ammoniakfordampningen, hvilket giver en bedre gødningsværdi i gyllen.<br><br>Flydelaget skal dække hele beholderens overflade, dog må der gerne være en brudflade op til 3 m2 ved det dykkede indløb.&nbsp;<br><br>Flydelaget kan etableres med en fast gødning eller fx snittet halm.<br><br>Hvis kommunen konstaterer mangelfuldt flydelag ved to tilsyn indenfor 3 år, skal overdækning påbydes, undtagen i særlige tilfælde, hvis kommunen ud fra en konkret vurdering finder, at overtrædelsen er undskyldelig.<br>|<br>If there is no fixed cover on a slurry tank, floating layers must be established on the slurry surface.<br><br>It must always be ensured that there is a tight floating layer. The floating layer limits the ammonia evaporation, which gives a better fertilizer value in the manure.<br><br>The floating layer must cover the entire surface of the container, however, there may be a breaking surface up to 3 m2 at the submerged inlet.<br><br>The floating layer can be established with a solid fertilizer or, for example, cut straw.<br><br>If the municipality finds a defective floating layer during two inspections within 3 years, cover must be imposed, except in special cases if the municipality, based on a specific assessment, finds that the violation is excusable.||<br> Якщо на резервуарі для гнойової рідини немає нерухомої кришки, на поверхні гнойової рідини повинні бути встановлені плаваючі шари.<br> < br>Завжди необхідно стежити за тим, щоб був щільний плаваючий шар. Плаваючий шар обмежує випаровування аміаку, що забезпечує кращу цінність добрив в гної.<br> < br> Плаваючий шар повинен покривати всю поверхню контейнера, однак на затопленому вході може бути поверхня розриву до 3 м2.<br> < br> Плаваючий шар може бути встановлений за допомогою твердого добрива або, наприклад, зрізаної соломи.<br><br>Якщо муніципалітет виявить дефектний плаваючий шар під час двох перевірок протягом 3 років, покриття повинно бути накладено, за винятком особливих випадків, якщо муніципалітет, грунтуючись на конкретній оцінці, виявить, що порушення можна пробачити.]]>
							</Description>
							<DisplayOrder>0</DisplayOrder>
							<Color>fff6df</Color>
						</DataItem>
					</DataItemList>
				</DataItemGroup>
			</DataItemGroupList>
			<DataItemList>
				<DataItem type=""CheckBox"">
					<Id>371625</Id>
					<Label>Flydelag OK|Floating layer OK||Плаваючий шар в порядку</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>2</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""SingleSelect"">
					<Id>371900</Id>
					<Label>Vælg årsag til manglende flydelag|Select reason for lack of floating layer||Виберіть причину відсутності плаваючого шару</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>3</DisplayOrder>
					<Mandatory>false</Mandatory>
					<KeyValuePairList>
						<KeyValuePair>
							<Key>1</Key>
							<Value>
								<![CDATA[Beholder omrørt|Slurry tank stirred||Резервуар для гнойової рідини перемішується]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>1</DisplayOrder>
						</KeyValuePair>
						<KeyValuePair>
							<Key>2</Key>
							<Value>
								<![CDATA[Gylle udbragt|Slurry delivered||Доставлений шлам]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>2</DisplayOrder>
						</KeyValuePair>
						<KeyValuePair>
							<Key>3</Key>
							<Value>
								<![CDATA[Beholder tom|Slurry tank empty||Ємність для шламу порожня]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>3</DisplayOrder>
						</KeyValuePair>
						<KeyValuePair>
							<Key>4</Key>
							<Value>
								<![CDATA[Halm tilført|Straw added||Додана солома]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>4</DisplayOrder>
						</KeyValuePair>
						<KeyValuePair>
							<Key>5</Key>
							<Value>
								<![CDATA[Flyttet til anden beholder|Moved to another slurry tank||Переїхав в інший резервуар для шламу]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>5</DisplayOrder>
						</KeyValuePair>
						<KeyValuePair>
							<Key>6</Key>
							<Value>
								<![CDATA[Modtaget biogas-gylle|Biogas slurry received||Отриманий біогазовий шлам]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>6</DisplayOrder>
						</KeyValuePair>
					</KeyValuePairList>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Picture"">
					<Id>371627</Id>
					<Label>Billede|Picture||Зображення</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>4</DisplayOrder>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Comment"">
					<Id>371628</Id>
					<Label>Kommentar|Comment||Коментар</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>5</DisplayOrder>
					<Multi>1</Multi>
					<GeolocationEnabled>false</GeolocationEnabled>
					<Split>false</Split>
					<Value/>
					<ReadOnly>false</ReadOnly>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""SaveButton"">
					<Id>371629</Id>
					<Label>Gem registrering|Save registration||Зберегти реєстрацію</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>6</DisplayOrder>
					<Value>GEM|SAVE||ЗБЕРЕГТИ</Value>
					<Color>f0f8db</Color>
				</DataItem>
			</DataItemList>
		</Element>
	</ElementList>
</Main>",
@"<?xml version=""1.0"" encoding=""UTF-8""?>
<Main>
	<Id>142060</Id>
	<Repeated>0</Repeated>
	<Label>03. Kontrol konstruktion|03. Control construction||03. Контрольна конструкції</Label>
	<StartDate>2020-08-07</StartDate>
	<EndDate>2030-08-07</EndDate>
	<Language>da</Language>
	<MultiApproval>false</MultiApproval>
	<FastNavigation>false</FastNavigation>
	<Review>false</Review>
	<Summary>false</Summary>
	<DisplayOrder>0</DisplayOrder>
	<ElementList>
		<Element type=""DataElement"">
			<Id>142060</Id>
			<Label>03. Kontrol konstruktion|03. Control construction03. Контрольна конструкції</Label>
			<Description>
				<![CDATA[Tjek for skader på kablerne, kabelomslutningen og fugemassen.|Check for damage to the cables, cable enclosure and sealant.||Перевірте, чи не пошкоджені кабелі, корпус кабелю і герметик.]]>
			</Description>
			<DisplayOrder>0</DisplayOrder>
			<ReviewEnabled>false</ReviewEnabled>
			<ManualSync>false</ManualSync>
			<ExtraFieldsEnabled>false</ExtraFieldsEnabled>
			<DoneButtonDisabled>true</DoneButtonDisabled>
			<ApprovalEnabled>false</ApprovalEnabled>
			<DataItemGroupList>
				<DataItemGroup type=""FieldGroup"">
					<Id>372224</Id>
					<Label>LÆS MERE|READ MORE||ДОКЛАДНО</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>0</DisplayOrder>
					<Value>Closed</Value>
					<Color>fff6df</Color>
					<DataItemList>
						<DataItem type=""None"">
							<Id>372225</Id>
							<Label>INFO|INFO||ІНФОРМАЦІЯ</Label>
							<Description>
								<![CDATA[Det skal altid sikres, at gyllebeholderne, fortanke og opsamlingsbeholderne har den fornødne styrke og tæthed, så udslip forhindres. Minimum en gang om året kontrolleres beholderne for skader.<br><br>Tjek for skader på kablerne. Kabler under jorden kan kun inspiceres ved at grave, og de bør derfor ikke inspiceres, med mindre der er mistanke om lækage.<br><br>Tjek om der er huller på kabelomslutningen. Det kan oftest ses ved, at fedtet er løbet ud af omslutningen og har skabt mørke pletter på beholderen.<br><br>Fugemassen kan være mørnet, hvilket du også skal tjekke.<br><br>Få udbedret eventuelle skader med det samme af en sagkyndig.<br>|<br>It must always be ensured that the slurry tanks, pre-tanks and collection tanks have the necessary strength and tightness, so that spills are prevented. Check the containers for damage at least once a year.<br><br>Check for damage to the cables. Underground cables can only be inspected by digging and should therefore not be inspected unless leakage is suspected.<br><br>Check for holes in the cable cover. This can most often be seen by the fact that the grease has run out of the enclosure and has created dark spots on the slurry tank.<br><br>The sealant may be softened, which you should also check.<br><br>Have any damage repaired immediately by an expert.||<br> Завжди необхідно забезпечувати, щоб резервуари для шламу, попередні резервуари та збірні резервуари мали необхідну міцність і герметичність, щоб запобігти розливу. Перевіряйте контейнери на наявність пошкоджень не рідше одного разу на рік.<br> <br>Перевіряйте, чи не пошкоджені кабелі. Підземні кабелі можуть бути перевірені тільки шляхом копання, і тому їх не слід перевіряти, якщо тільки не підозрюється витік.<br> <br>Перевірте, чи немає отворів в кришці кабелю. Найчастіше це можна побачити по тому факту, що мастило витекло з корпусу і створило темні плями на резервуарі для шламу.<br> <br> Герметик може розм'якшитись, що також слід перевірити.<br> <br>Негайно усуньте будь-які пошкодження у експерта.]]>
							</Description>
							<DisplayOrder>0</DisplayOrder>
							<Color>fff6df</Color>
						</DataItem>
					</DataItemList>
				</DataItemGroup>
			</DataItemGroupList>
			<DataItemList>
				<DataItem type=""CheckBox"">
					<Id>371011</Id>
					<Label>Kabler OK|Cables OK||Кабелі в порядку</Label>
					<Description>
						<![CDATA[Der må ikke være synlige skader på kablerne.|There must be no visible damage to the cables.||На кабелях не повинно бути видимих пошкоджень.]]>
					</Description>
					<DisplayOrder>1</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>372047</Id>
					<Label>Kabelomslutning OK|Cable enclosure OK||Кабельний корпус в порядку</Label>
					<Description>
						<![CDATA[Huller på kabelomslutning kan oftest ses ved, at fedtet er løbet ud af omslutningen og har skabt mørke pletter på beholderen.|Holes on the cable enclosure can most often be seen by the grease running out of the enclosure and creating dark stains on the container.||Отвори на корпусі кабелю найчастіше видно по мастилу, що випливає з корпусу і утворює темні плями на контейнері.]]>
					</Description>
					<DisplayOrder>2</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>372048</Id>
					<Label>Fugemassen OK|Sealant OK||Герметик в порядку</Label>
					<Description>
						<![CDATA[Fugemassen må ikke være mørnet.|The sealant must not be softened.||Герметик не повинен розм'якшуватися.]]>
					</Description>
					<DisplayOrder>3</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Picture"">
					<Id>371014</Id>
					<Label>Billede|Picture||Зображення</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>4</DisplayOrder>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Comment"">
					<Id>371015</Id>
					<Label>Kommentar|Comment||Коментар</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>5</DisplayOrder>
					<Multi>1</Multi>
					<GeolocationEnabled>false</GeolocationEnabled>
					<Split>false</Split>
					<Value/>
					<ReadOnly>false</ReadOnly>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""SaveButton"">
					<Id>371016</Id>
					<Label>Gem registrering|Save registration||Зберегти реєстрацію</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>6</DisplayOrder>
					<Value>GEM|SAVE||ЗБЕРЕГТИ</Value>
					<Color>f0f8db</Color>
				</DataItem>
			</DataItemList>
		</Element>
	</ElementList>
</Main>",
@"<?xml version=""1.0"" encoding=""UTF-8""?>
<Main>
	<Id>142289</Id>
	<Repeated>0</Repeated>
	<Label>04. Foderindlægssedler|04. Feeding documentation||04. Документація по годівлі</Label>
	<StartDate>2021-02-02</StartDate>
	<EndDate>2031-02-02</EndDate>
	<Language>da</Language>
	<MultiApproval>false</MultiApproval>
	<FastNavigation>false</FastNavigation>
	<Review>false</Review>
	<Summary>false</Summary>
	<DisplayOrder>0</DisplayOrder>
	<ElementList>
		<Element type=""DataElement"">
			<Id>142289</Id>
			<Label>04. Foderindlægssedler|04. Feeding documentation||04. Документація по годівлі</Label>
			<Description>
				<![CDATA[Tag billeder af foderindlægssedlerne.|Take pictures of the feed package leaflets.||Сфотографуйте листівки з упаковкою корму.]]>
			</Description>
			<DisplayOrder>0</DisplayOrder>
			<ReviewEnabled>false</ReviewEnabled>
			<ManualSync>false</ManualSync>
			<ExtraFieldsEnabled>false</ExtraFieldsEnabled>
			<DoneButtonDisabled>true</DoneButtonDisabled>
			<ApprovalEnabled>false</ApprovalEnabled>
			<DataItemGroupList>
				<DataItemGroup type=""FieldGroup"">
					<Id>372775</Id>
					<Label>LÆS MERE|READ MORE||ДОКЛАДНО</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>0</DisplayOrder>
					<Value>Closed</Value>
					<Color>fff6df</Color>
					<DataItemList>
						<DataItem type=""None"">
							<Id>372776</Id>
							<Label>INFO|INFO||ІНФОРМАЦІЯ</Label>
							<Description>
								<![CDATA[Tag billeder af foderindlægssedlerne.|Take pictures of the feed package leaflets.||Сфотографуйте листівки з упаковкою корму.]]>
							</Description>
							<DisplayOrder>0</DisplayOrder>
							<Color>fff6df</Color>
						</DataItem>
					</DataItemList>
				</DataItemGroup>
			</DataItemGroupList>
			<DataItemList>
				<DataItem type=""Picture"">
					<Id>372772</Id>
					<Label>Billede af foderindlægssedler|Picture of feed leaflets||Зображення кормових листівок</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>6</DisplayOrder>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Comment"">
					<Id>372771</Id>
					<Label>Kommentar|Comment||Коментар</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>7</DisplayOrder>
					<Multi>1</Multi>
					<GeolocationEnabled>false</GeolocationEnabled>
					<Split>false</Split>
					<Value/>
					<ReadOnly>false</ReadOnly>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""SaveButton"">
					<Id>372773</Id>
					<Label>Gem registrering|Save registration||Зберегти реєстрацію</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>8</DisplayOrder>
					<Value>GEM|SAVE||ЗБЕРЕГТИ</Value>
					<Color>f0f8db</Color>
				</DataItem>
			</DataItemList>
		</Element>
	</ElementList>
</Main>",
@"<?xml version=""1.0"" encoding=""UTF-8""?>
<Main>
	<Id>142288</Id>
	<Repeated>0</Repeated>
	<Label>05. Stald_klargøring|05. Stable_prep||05. Підготовка стаєнь</Label>
	<StartDate>2021-01-31</StartDate>
	<EndDate>2031-01-31</EndDate>
	<Language>da</Language>
	<MultiApproval>false</MultiApproval>
	<FastNavigation>false</FastNavigation>
	<Review>false</Review>
	<Summary>false</Summary>
	<DisplayOrder>0</DisplayOrder>
	<ElementList>
		<Element type=""DataElement"">
			<Id>142288</Id>
			<Label>05. Stald_klargøring|05. Stable_prep||05. Підготовка стаєнь</Label>
			<Description>
				<![CDATA[Klargøringstjek af stald|Preparation check of stable<br>||Перевірка підготовки стаєнь]]>
			</Description>
			<DisplayOrder>0</DisplayOrder>
			<ReviewEnabled>false</ReviewEnabled>
			<ManualSync>false</ManualSync>
			<ExtraFieldsEnabled>false</ExtraFieldsEnabled>
			<DoneButtonDisabled>true</DoneButtonDisabled>
			<ApprovalEnabled>false</ApprovalEnabled>
			<DataItemGroupList>
				<DataItemGroup type=""FieldGroup"">
					<Id>372762</Id>
					<Label>LÆS MERE|READ MORE||ДОКЛАДНО</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>0</DisplayOrder>
					<Value>Closed</Value>
					<Color>fff6df</Color>
					<DataItemList>
						<DataItem type=""None"">
							<Id>372763</Id>
							<Label>INFO|INFO||ІНФОРМАЦІЯ</Label>
							<Description>
								<![CDATA[Klargøringstjek af stald|Preparation check of stable||Перевірка підготовки стаєнь]]>
							</Description>
							<DisplayOrder>0</DisplayOrder>
							<Color>fff6df</Color>
						</DataItem>
					</DataItemList>
				</DataItemGroup>
			</DataItemGroupList>
			<DataItemList>
				<DataItem type=""CheckBox"">
					<Id>372764</Id>
					<Label>1. Afprøv ventil i vandkop|1. Test valve in water cup||1. Випробувальний клапан в склянці з водою</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>1</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>373061</Id>
					<Label>2. Afprøv ventilationsanlæg (min. og max. indstilling)|2. Test ventilation system (min. and max. setting)||2. Перевірте системи вентиляції (мінімальна і максимальна настройка)</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>2</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>372766</Id>
					<Label>3. Gennemfør følertest|3. Perform sensor tests||3. Проведіть випробування датчиків</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>3</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>372765</Id>
					<Label>4. Afprøv og indstil foderautomat|4. Test and set the feeder||4. Перевірте та відрегулюйте пристрій подачі</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>4</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>372767</Id>
					<Label>5. Tjek at legetøj er nyt/rent|5. Check that toys are new/clean||5. Переконайтеся, що іграшки нові / чисті</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>5</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>372768</Id>
					<Label>6. Tjek overbrusning og rens evt. filter|6. Check sprinkling and clean - if necessary - filter||6. Перевірте розбризкування і очистіть - при необхідності - фільтр</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>6</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>372769</Id>
					<Label>7. Tjek at alarm virker|7. Check that the alarm works||7. Перевірте, чи працює сигналізація</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>7</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>374039</Id>
					<Label>8. Vask udsugning|8. Wash exhaust||8. Вимийте вихлопні гази</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>8</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Picture"">
					<Id>372759</Id>
					<Label>Billede|Picture||Зображення</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>9</DisplayOrder>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Comment"">
					<Id>372758</Id>
					<Label>Kommentar|Comment||Коментар</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>10</DisplayOrder>
					<Multi>1</Multi>
					<GeolocationEnabled>false</GeolocationEnabled>
					<Split>false</Split>
					<Value/>
					<ReadOnly>false</ReadOnly>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""SaveButton"">
					<Id>372760</Id>
					<Label>Gem registrering|Save registration||Зберегти реєстрацію</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>11</DisplayOrder>
					<Value>GEM|SAVE||ЗБЕРЕГТИ</Value>
					<Color>f0f8db</Color>
				</DataItem>
			</DataItemList>
		</Element>
	</ElementList>
</Main>",
@"<?xml version=""1.0"" encoding=""UTF-8""?>
<Main>
	<Id>142226</Id>
	<Repeated>0</Repeated>
	<Label>06. Siloer|06. Silos||06. Бункер</Label>
	<StartDate>2020-12-28</StartDate>
	<EndDate>2030-12-28</EndDate>
	<Language>da</Language>
	<MultiApproval>false</MultiApproval>
	<FastNavigation>false</FastNavigation>
	<Review>false</Review>
	<Summary>false</Summary>
	<DisplayOrder>0</DisplayOrder>
	<ElementList>
		<Element type=""DataElement"">
			<Id>142226</Id>
			<Label>06. Siloer|06. Silos||06. Бункер</Label>
			<Description>
				<![CDATA[Kontrol af foderspild og rørsamlinger|Control of feed spills and pipe joints<br><br>||Контроль розливів сировини і з'єднань труб<br><br>]]>
			</Description>
			<DisplayOrder>0</DisplayOrder>
			<ReviewEnabled>false</ReviewEnabled>
			<ManualSync>false</ManualSync>
			<ExtraFieldsEnabled>false</ExtraFieldsEnabled>
			<DoneButtonDisabled>true</DoneButtonDisabled>
			<ApprovalEnabled>false</ApprovalEnabled>
			<DataItemGroupList>
				<DataItemGroup type=""FieldGroup"">
					<Id>372308</Id>
					<Label>LÆS MERE|READ MORE||ДОКЛАДНО</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>0</DisplayOrder>
					<Value>Closed</Value>
					<Color>fff6df</Color>
					<DataItemList>
						<DataItem type=""None"">
							<Id>372309</Id>
							<Label>INFO|INFO||ІНФОРМАЦІЯ</Label>
							<Description>
								<![CDATA[Opbevaring af foder skal ske på en måde, så tilhold af skadedyr forebygges, og spild ikke giver anledning til punktforurening.  <br><br>Dette forebygges ved at sikre, at foder opbevares i tætte og dertil egnede beholdere.<br><br>Der vil kunne ske spild af foder fx ved utætte samlinger, levering/indblæsning af foder eller lignende. Sker der spild af foder, er det vigtigt, at der løbende bliver samlet op, så fx tilhold af rotter undgås.|<br>Feed must be stored in such a way that pests are prevented and spills do not give rise to point pollution.<br><br>This is prevented by ensuring that feed is stored in tight and suitable containers.<br><br>There may be a waste of feed, for example by leaky joints, delivery / supply of feed or the like. If there is a waste of feed, it is important that it is collected regularly, so that, for example, the presence of rats is avoided.||< br> Корми повинні зберігатися таким чином, щоб запобігти появі шкідників і не привести до точкового забруднення.<br> < br> Цього можна уникнути, забезпечивши Зберігання корму в герметичних і відповідних контейнерах.<br> < br> Може статися втрата корму, наприклад, через негерметичні з'єднання, доставки / подачі корму або тому подібного. Якщо є відходи корму, важливо, щоб він регулярно збирався, щоб, наприклад, уникнути присутності щурів.]]>
							</Description>
							<DisplayOrder>0</DisplayOrder>
							<Color>fff6df</Color>
						</DataItem>
					</DataItemList>
				</DataItemGroup>
			</DataItemGroupList>
			<DataItemList>
				<DataItem type=""CheckBox"">
					<Id>372307</Id>
					<Label>Ingen foderspild|No feed spills||Ніяких розливів корму</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>1</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>372310</Id>
					<Label>Rørsamlinger tætte|Pipe joints tight||Герметичні з'єднання труб</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>2</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Picture"">
					<Id>372305</Id>
					<Label>Billede|Picture||Зображення</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>5</DisplayOrder>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Comment"">
					<Id>372304</Id>
					<Label>Kommentar|Comment||Коментар</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>6</DisplayOrder>
					<Multi>1</Multi>
					<GeolocationEnabled>false</GeolocationEnabled>
					<Split>false</Split>
					<Value/>
					<ReadOnly>false</ReadOnly>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""SaveButton"">
					<Id>372306</Id>
					<Label>Gem registrering|Save registration||Зберегти реєстрацію</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>7</DisplayOrder>
					<Value>GEM|SAVE||ЗБЕРЕГТИ</Value>
					<Color>f0f8db</Color>
				</DataItem>
			</DataItemList>
		</Element>
	</ElementList>
</Main>",
@"<?xml version=""1.0"" encoding=""UTF-8""?>
<Main>
	<Id>142271</Id>
	<Repeated>0</Repeated>
	<Label>07. Fluer|07. Flies||07. Мухи</Label>
	<StartDate>2021-01-17</StartDate>
	<EndDate>2031-01-17</EndDate>
	<Language>da</Language>
	<MultiApproval>false</MultiApproval>
	<FastNavigation>false</FastNavigation>
	<Review>false</Review>
	<Summary>false</Summary>
	<DisplayOrder>0</DisplayOrder>
	<ElementList>
		<Element type=""DataElement"">
			<Id>142271</Id>
			<Label>07. Fluer|07. Flies||07. Мухи</Label>
			<Description>
				<![CDATA[Tag billede af serviceaftale/faktura|Take picture of service agreement/invoice||Сфотографуйте угоду про обслуговування/рахунок-фактуру]]>
			</Description>
			<DisplayOrder>0</DisplayOrder>
			<ReviewEnabled>false</ReviewEnabled>
			<ManualSync>false</ManualSync>
			<ExtraFieldsEnabled>false</ExtraFieldsEnabled>
			<DoneButtonDisabled>true</DoneButtonDisabled>
			<ApprovalEnabled>false</ApprovalEnabled>
			<DataItemGroupList>
				<DataItemGroup type=""FieldGroup"">
					<Id>372587</Id>
					<Label>LÆS MERE|READ MORE||ДОКЛАДНО</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>0</DisplayOrder>
					<Value>Closed</Value>
					<Color>fff6df</Color>
					<DataItemList>
						<DataItem type=""None"">
							<Id>372588</Id>
							<Label>INFO|INFO||ІНФОРМАЦІЯ</Label>
							<Description>
								<![CDATA[De vigtigste punkter ved bekæmpelse af fluer er god gødningshåndtering og en generel god staldhygiejne.<br><br>Når du tager et billede af din serviceftale og/eller faktura på fluebekæmpelse, er den nem at finde frem på web, når du har brug for at kunne fremvise denne til f.eks. tilsynsmyndighederne.<br>|<br>The most important points when controlling flies are good manure handling and a generally good stable hygiene.<br><br>When you take a picture of your service agreement and / or invoice for fly control, it is easy to find on the web when you need to be able to present it to e.g. supervisory authorities.||<br> Найбільш важливими моментами при боротьбі з мухами є хороша обробка гною і в цілому хороша гігієна стаєнь.<br><br>Коли ви фотографуєте свою угоду про обслуговування та / або рахунок-фактуру для контролю мух, його легко знайти в Інтернеті, коли вам потрібно мати можливість представити його, наприклад, наглядовим органам.]]>
							</Description>
							<DisplayOrder>0</DisplayOrder>
							<Color>fff6df</Color>
						</DataItem>
					</DataItemList>
				</DataItemGroup>
			</DataItemGroupList>
			<DataItemList>
				<DataItem type=""Picture"">
					<Id>372585</Id>
					<Label>Billede serviceaftale/faktura|Picture service agreement/invoice||Зображення угоди про обслуговування/рахунок-фактура</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>5</DisplayOrder>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Comment"">
					<Id>372584</Id>
					<Label>Kommentar|Comment||Коментар</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>6</DisplayOrder>
					<Multi>1</Multi>
					<GeolocationEnabled>false</GeolocationEnabled>
					<Split>false</Split>
					<Value/>
					<ReadOnly>false</ReadOnly>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""SaveButton"">
					<Id>372586</Id>
					<Label>Gem registrering|Save registration||Зберегти реєстрацію</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>7</DisplayOrder>
					<Value>GEM|SAVE||ЗБЕРЕГТИ</Value>
					<Color>f0f8db</Color>
				</DataItem>
			</DataItemList>
		</Element>
	</ElementList>
</Main>",
@"<?xml version=""1.0"" encoding=""UTF-8""?>
<Main>
	<Id>142270</Id>
	<Repeated>0</Repeated>
	<Label>07. Rotter|07. Rats||07. Щури</Label>
	<StartDate>2021-01-17</StartDate>
	<EndDate>2031-01-17</EndDate>
	<Language>da</Language>
	<MultiApproval>false</MultiApproval>
	<FastNavigation>false</FastNavigation>
	<Review>false</Review>
	<Summary>false</Summary>
	<DisplayOrder>0</DisplayOrder>
	<ElementList>
		<Element type=""DataElement"">
			<Id>142270</Id>
			<Label>07. Rotter|07. Rats||07. Щури</Label>
			<Description>
				<![CDATA[Tag billede af serviceaftale/faktura|Take picture of service agreement/invoice||Сфотографуйте угоду про обслуговування / рахунок-фактуру]]>
			</Description>
			<DisplayOrder>0</DisplayOrder>
			<ReviewEnabled>false</ReviewEnabled>
			<ManualSync>false</ManualSync>
			<ExtraFieldsEnabled>false</ExtraFieldsEnabled>
			<DoneButtonDisabled>true</DoneButtonDisabled>
			<ApprovalEnabled>false</ApprovalEnabled>
			<DataItemGroupList>
				<DataItemGroup type=""FieldGroup"">
					<Id>372582</Id>
					<Label>LÆS MERE|READ MORE||ДОКЛАДНО</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>0</DisplayOrder>
					<Value>Closed</Value>
					<Color>fff6df</Color>
					<DataItemList>
						<DataItem type=""None"">
							<Id>372583</Id>
							<Label>INFO|INFO||ІНФОРМАЦІЯ</Label>
							<Description>
								<![CDATA[Effektive virkemidler mod rotter er orden, ryddelighed, fejede gulve, fjernelse af vegetation langs bygninger, reparation af huller/rørgennemføringer, at døre/porte for så vidt muligt holdes lukkede og at oplag af “diverse” sættes på paller og strøer.<br><br>Når du tager et billede af din serviceftale og/eller faktura på rottebekæmpelse, er den nem at finde frem på web, når du har brug for at kunne fremvise denne til f.eks. tilsynsmyndighederne.<br>|<br>Effective measures against rats are order, tidiness, swept floors, removal of vegetation along buildings, repair of holes / pipe penetrations, that doors / gates are kept closed as far as possible and that storage of ""miscellaneous"" is placed on pallets and joists.<br><br>When you take a picture of your service agreement and / or invoice for rat control, it is easy to find on the web when you need to be able to present it to e.g. supervisory authorities.||<br>Ефективними заходами проти щурів є порядок, охайність, підмітені підлоги, видалення рослинності вздовж будівель, ремонт отворів / проходів труб, щоб Двері / ворота залишалися закритими, наскільки це можливо, і щоб зберігання ""різного"" розміщувалося на піддонах і балках.<br><br>Коли ви фотографуєте свою угоду про надання послуг та / або рахунок-фактуру для контролю щурів, його легко знайти в Інтернеті, коли вам потрібно мати можливість представити його, наприклад, наглядовим органам.]]>
							</Description>
							<DisplayOrder>0</DisplayOrder>
							<Color>fff6df</Color>
						</DataItem>
					</DataItemList>
				</DataItemGroup>
			</DataItemGroupList>
			<DataItemList>
				<DataItem type=""Picture"">
					<Id>372580</Id>
					<Label>Billede serviceaftale/faktura|Picture service agreement/invoice||Зображення угоди про обслуговування/рахунку-фактури</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>5</DisplayOrder>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Comment"">
					<Id>372579</Id>
					<Label>Kommentar|Comment||Коментар</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>6</DisplayOrder>
					<Multi>1</Multi>
					<GeolocationEnabled>false</GeolocationEnabled>
					<Split>false</Split>
					<Value/>
					<ReadOnly>false</ReadOnly>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""SaveButton"">
					<Id>372581</Id>
					<Label>Gem registrering|Save registration||Зберегти реєстрацію</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>7</DisplayOrder>
					<Value>GEM|SAVE||ЗБЕРЕГТИ</Value>
					<Color>f0f8db</Color>
				</DataItem>
			</DataItemList>
		</Element>
	</ElementList>
</Main>",
@"<?xml version=""1.0"" encoding=""UTF-8""?>
<Main>
	<Id>142589</Id>
	<Repeated>0</Repeated>
	<Label>08. Luftrensning driftsstop|08. Air cleaning downtime||08. Час простою при очищенні повітря</Label>
	<StartDate>2021-09-08</StartDate>
	<EndDate>2031-09-08</EndDate>
	<Language>da</Language>
	<MultiApproval>false</MultiApproval>
	<FastNavigation>false</FastNavigation>
	<Review>false</Review>
	<Summary>false</Summary>
	<DisplayOrder>0</DisplayOrder>
	<ElementList>
		<Element type=""DataElement"">
			<Id>142589</Id>
			<Label>08. Luftrensning driftsstop|08. Air cleaning downtime||08. Час простою при очищенні повітря</Label>
			<Description>
				<![CDATA[Logbog driftsstop|Logbook downtime||Журнал часу простою]]>
			</Description>
			<DisplayOrder>0</DisplayOrder>
			<ReviewEnabled>false</ReviewEnabled>
			<ManualSync>false</ManualSync>
			<ExtraFieldsEnabled>false</ExtraFieldsEnabled>
			<DoneButtonDisabled>true</DoneButtonDisabled>
			<ApprovalEnabled>false</ApprovalEnabled>
			<DataItemGroupList>
				<DataItemGroup type=""FieldGroup"">
					<Id>375175</Id>
					<Label>LÆS MERE|READ MORE||ДОКЛАДНО</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>0</DisplayOrder>
					<Value>Closed</Value>
					<Color>fff6df</Color>
					<DataItemList>
						<DataItem type=""None"">
							<Id>375176</Id>
							<Label>INFO|INFO||ІНФОРМАЦІЯ</Label>
							<Description>
								<![CDATA[Bruges som ammoniak- og lugtreducerende tiltag i svinestalde og kan være stillet som et vilkår i husdyrbrugets miljøgodkendelse. <br><br>Hvis der er installeret luftrensning, skal man være opmærksom på vilkår om logbog, og hvad der skal registreres heri. Se miljøgodkendelsen.  <br><br>Vedligeholdelse af anlægget skal følge producentens anvisninger.<br>|<br>Used as an ammonia and odor-reducing measure in pig stables and can be made a condition in the livestock farm's environmental approval.<br><br>If air purification is installed, you must be aware of the terms of the logbook and what must be registered in it. See the environmental approval.<br><br>Maintenance of the system must follow the manufacturer's instructions.<br>||<br>Використовується в якості заходу по зменшенню аміаку і запаху в свинарниках і може бути внесено в екологічне схвалення тваринницької ферми.<br><br> Якщо встановлено очищення повітря, ви повинні бути інформовані про умови ведення журналу і про те, що в ньому має бути зареєстровано. Див. Екологічне схвалення.<br><br>Технічне обслуговування системи повинно здійснюватися відповідно до інструкцій виробника.<br>]]>
							</Description>
							<DisplayOrder>0</DisplayOrder>
							<Color>fff6df</Color>
						</DataItem>
					</DataItemList>
				</DataItemGroup>
			</DataItemGroupList>
			<DataItemList>
				<DataItem type=""Date"">
					<Id>375177</Id>
					<Label>Sæt startdato for driftsstop|Set startdate for shutdown||Встановіть дату початку простою</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>1</DisplayOrder>
					<MinValue>2021-09-08</MinValue>
					<MaxValue>2031-09-08</MaxValue>
					<Value/>
					<Mandatory>false</Mandatory>
					<ReadOnly>false</ReadOnly>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Date"">
					<Id>375178</Id>
					<Label>Sæt slutdato for driftsstop|Set end date for shutdown||Встановіть кінцеву дату простою</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>2</DisplayOrder>
					<MinValue>2021-09-08</MinValue>
					<MaxValue>2031-09-08</MaxValue>
					<Value/>
					<Mandatory>false</Mandatory>
					<ReadOnly>false</ReadOnly>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Number"">
					<Id>375174</Id>
					<Label>Driftsstop timer|Downtime hours||Години простою</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>3</DisplayOrder>
					<Mandatory>false</Mandatory>
					<MinValue/>
					<MaxValue/>
					<Value/>
					<DecimalCount/>
					<UnitName/>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Comment"">
					<Id>375179</Id>
					<Label>Årsag til driftsstop|Cause of shutdown||Причина відключення</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>4</DisplayOrder>
					<Multi>1</Multi>
					<GeolocationEnabled>false</GeolocationEnabled>
					<Split>false</Split>
					<Value/>
					<ReadOnly>false</ReadOnly>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Picture"">
					<Id>375172</Id>
					<Label>Billede|Picture||Зображення</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>5</DisplayOrder>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Comment"">
					<Id>375171</Id>
					<Label>Kommentar|Comment||Коментар</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>6</DisplayOrder>
					<Multi>1</Multi>
					<GeolocationEnabled>false</GeolocationEnabled>
					<Split>false</Split>
					<Value/>
					<ReadOnly>false</ReadOnly>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""SaveButton"">
					<Id>375173</Id>
					<Label>Gem registrering|Save registration||Зберегти реєстрацію</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>7</DisplayOrder>
					<Value>GEM|SAVE||ЗБЕРЕГТИ</Value>
					<Color>f0f8db</Color>
				</DataItem>
			</DataItemList>
		</Element>
	</ElementList>
</Main>",
@"<?xml version=""1.0"" encoding=""UTF-8""?>
<Main>
	<Id>142237</Id>
	<Repeated>0</Repeated>
	<Label>08. Luftrensning serviceaftale|08. Air cleaning service agreement||08. Угода про послуги з очищення повітря</Label>
	<StartDate>2020-12-28</StartDate>
	<EndDate>2030-12-28</EndDate>
	<Language>da</Language>
	<MultiApproval>false</MultiApproval>
	<FastNavigation>false</FastNavigation>
	<Review>false</Review>
	<Summary>false</Summary>
	<DisplayOrder>0</DisplayOrder>
	<ElementList>
		<Element type=""DataElement"">
			<Id>142237</Id>
			<Label>08. Luftrensning serviceaftale|08. Air cleaning service agreement||08. Угода про послуги з очищення повітря</Label>
			<Description>
				<![CDATA[Billede af serviceaftale/faktura|Picture service agreement/invoice||Зображення угоди про обслуговування/рахунок-фактура]]>
			</Description>
			<DisplayOrder>0</DisplayOrder>
			<ReviewEnabled>false</ReviewEnabled>
			<ManualSync>false</ManualSync>
			<ExtraFieldsEnabled>false</ExtraFieldsEnabled>
			<DoneButtonDisabled>true</DoneButtonDisabled>
			<ApprovalEnabled>false</ApprovalEnabled>
			<DataItemGroupList>
				<DataItemGroup type=""FieldGroup"">
					<Id>372361</Id>
					<Label>LÆS MERE|READ MORE||ДОКЛАДНО</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>0</DisplayOrder>
					<Value>Closed</Value>
					<Color>fff6df</Color>
					<DataItemList>
						<DataItem type=""None"">
							<Id>372362</Id>
							<Label>INFO|INFO||ІНФОРМАЦІЯ</Label>
							<Description>
								<![CDATA[Når du tager et billede af din serviceftale og/eller faktura, er den nem at finde frem på web, når du har brug for at kunne fremvise denne til f.eks. tilsynsmyndighederne.|When you take a picture of your service agreement and / or invoice, it is easy to find on the web when you need to be able to present it to e.g. supervisory authorities.||Коли ви фотографуєте свою угоду про надання послуг та / або рахунок-фактуру, його легко знайти в Інтернеті, коли вам потрібно мати можливість представити його, наприклад, наглядовим органам.]]>
							</Description>
							<DisplayOrder>0</DisplayOrder>
							<Color>fff6df</Color>
						</DataItem>
					</DataItemList>
				</DataItemGroup>
			</DataItemGroupList>
			<DataItemList>
				<DataItem type=""Picture"">
					<Id>372360</Id>
					<Label>Billede serviceaftale|Picture service agreement||Зображення угоди про обслуговування</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>1</DisplayOrder>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Picture"">
					<Id>372358</Id>
					<Label>Billede faktura|Picture invoice||Зображення рахунку-фактури</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>4</DisplayOrder>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Comment"">
					<Id>372357</Id>
					<Label>Kommentar|Comment||Коментар</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>5</DisplayOrder>
					<Multi>1</Multi>
					<GeolocationEnabled>false</GeolocationEnabled>
					<Split>false</Split>
					<Value/>
					<ReadOnly>false</ReadOnly>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""SaveButton"">
					<Id>372359</Id>
					<Label>Gem registrering|Save registration||Зберегти реєстрацію</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>6</DisplayOrder>
					<Value>GEM|SAVE||ЗБЕРЕГТИ</Value>
					<Color>f0f8db</Color>
				</DataItem>
			</DataItemList>
		</Element>
	</ElementList>
</Main>",
@"<?xml version=""1.0"" encoding=""UTF-8""?>
<Main>
	<Id>142236</Id>
	<Repeated>0</Repeated>
	<Label>08. Luftrensning timer|08. Air cleaning hours||08. Години очищення повітря</Label>
	<StartDate>2020-12-28</StartDate>
	<EndDate>2030-12-28</EndDate>
	<Language>da</Language>
	<MultiApproval>false</MultiApproval>
	<FastNavigation>false</FastNavigation>
	<Review>false</Review>
	<Summary>false</Summary>
	<DisplayOrder>0</DisplayOrder>
	<ElementList>
		<Element type=""DataElement"">
			<Id>142236</Id>
			<Label>08. Luftrensning timer|08. Air cleaning hours||08. Години очищення повітря</Label>
			<Description>
				<![CDATA[Luftrensning timeaflæsning|Air cleaning hour meter||Лічильник годин очищення повітря]]>
			</Description>
			<DisplayOrder>0</DisplayOrder>
			<ReviewEnabled>false</ReviewEnabled>
			<ManualSync>false</ManualSync>
			<ExtraFieldsEnabled>false</ExtraFieldsEnabled>
			<DoneButtonDisabled>true</DoneButtonDisabled>
			<ApprovalEnabled>false</ApprovalEnabled>
			<DataItemGroupList>
				<DataItemGroup type=""FieldGroup"">
					<Id>372355</Id>
					<Label>LÆS MERE|READ MORE||ДОКЛАДНО</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>0</DisplayOrder>
					<Value>Closed</Value>
					<Color>fff6df</Color>
					<DataItemList>
						<DataItem type=""None"">
							<Id>372356</Id>
							<Label>INFO|INFO||ІНФОРМАЦІЯ</Label>
							<Description>
								<![CDATA[Bruges som ammoniak- og lugtreducerende tiltag i svinestalde og kan være stillet som et vilkår i husdyrbrugets miljøgodkendelse. <br><br>Hvis der er installeret luftrensning, skal man være opmærksom på vilkår om logbog, og hvad der skal registreres heri. Se miljøgodkendelsen.  <br><br>Vedligeholdelse af anlægget skal følge producentens anvisninger.<br>|<br>Used as an ammonia and odor-reducing measure in pig stables and can be made a condition in the livestock farm's environmental approval.<br><br>If air purification is installed, you must be aware of the terms of the logbook and what must be registered in it. See the environmental approval.<br><br>Maintenance of the system must follow the manufacturer's instructions.<br>||<br>Використовується в якості заходу по зменшенню аміаку і запаху в свинарниках і може бути внесено в екологічне схвалення тваринницької ферми.<br><br> Якщо встановлено очищення повітря, ви повинні бути інформовані про умови ведення журналу і про те, що в ньому має бути зареєстровано. Див. Екологічне схвалення.<br><br>Технічне обслуговування системи повинно здійснюватися відповідно до інструкцій виробника.<br>]]>
							</Description>
							<DisplayOrder>0</DisplayOrder>
							<Color>fff6df</Color>
						</DataItem>
					</DataItemList>
				</DataItemGroup>
			</DataItemGroupList>
			<DataItemList>
				<DataItem type=""Number"">
					<Id>372354</Id>
					<Label>Luftrensning timeaflæsning|Air cleaning hour meter||Лічильник годин очищення повітря</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>1</DisplayOrder>
					<Mandatory>false</Mandatory>
					<MinValue/>
					<MaxValue/>
					<Value/>
					<DecimalCount/>
					<UnitName/>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Picture"">
					<Id>372352</Id>
					<Label>Billede|Picture||Зображення</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>4</DisplayOrder>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Comment"">
					<Id>372351</Id>
					<Label>Kommentar|Comment||Коментар</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>5</DisplayOrder>
					<Multi>1</Multi>
					<GeolocationEnabled>false</GeolocationEnabled>
					<Split>false</Split>
					<Value/>
					<ReadOnly>false</ReadOnly>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""SaveButton"">
					<Id>372353</Id>
					<Label>Gem registrering|Save registration||Зберегти реєстрацію</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>6</DisplayOrder>
					<Value>GEM|SAVE||ЗБЕРЕГТИ</Value>
					<Color>f0f8db</Color>
				</DataItem>
			</DataItemList>
		</Element>
	</ElementList>
</Main>",
@"<?xml version=""1.0"" encoding=""UTF-8""?>
<Main>
	<Id>142590</Id>
	<Repeated>0</Repeated>
	<Label>09. Forsuring driftsstop|09. Acidification downtime||09. Час простою при підкисленні</Label>
	<StartDate>2021-09-08</StartDate>
	<EndDate>2031-09-08</EndDate>
	<Language>da</Language>
	<MultiApproval>false</MultiApproval>
	<FastNavigation>false</FastNavigation>
	<Review>false</Review>
	<Summary>false</Summary>
	<DisplayOrder>0</DisplayOrder>
	<ElementList>
		<Element type=""DataElement"">
			<Id>142590</Id>
			<Label>09. Forsuring driftsstop|09. Acidification downtime||09. Час простою при підкисленні</Label>
			<Description>
				<![CDATA[Logbog driftsstop|Logbook downtime||Журнал часу простою]]>
			</Description>
			<DisplayOrder>0</DisplayOrder>
			<ReviewEnabled>false</ReviewEnabled>
			<ManualSync>false</ManualSync>
			<ExtraFieldsEnabled>false</ExtraFieldsEnabled>
			<DoneButtonDisabled>true</DoneButtonDisabled>
			<ApprovalEnabled>false</ApprovalEnabled>
			<DataItemGroupList>
				<DataItemGroup type=""FieldGroup"">
					<Id>375184</Id>
					<Label>LÆS MERE|READ MORE||ДОКЛАДНО</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>0</DisplayOrder>
					<Value>Closed</Value>
					<Color>fff6df</Color>
					<DataItemList>
						<DataItem type=""None"">
							<Id>375185</Id>
							<Label>INFO|INFO||ІНФОРМАЦІЯ</Label>
							<Description>
								<![CDATA[Bruges som ammoniakreducerende tiltag.<br><br>Hvis der er installeret forsuringsanlæg, skal man være opmærksom på vilkår om logbog, og hvad der skal registreres heri. Se miljøgodkendelsen.<br><br>Vedligeholdelse af anlægget skal følge producentens anvisninger.<br>|<br>Used as an ammonia-reducing measure.<br><br>If acidification systems have been installed, you must be aware of the terms of the logbook and what must be registered in it. See the environmental approval.<br><br>Maintenance of the system must follow the manufacturer's instructions.<br>||<br>Використовується в якості заходу щодо зниження вмісту аміаку.<br><br>Якщо були встановлені системи підкислення, ви повинні бути інформовані про умови ведення журналу і про те, що в ньому має бути зареєстровано. Див. Екологічне схвалення.<br><br>Технічне обслуговування системи повинно здійснюватися відповідно до інструкцій виробника.<br>]]>
							</Description>
							<DisplayOrder>0</DisplayOrder>
							<Color>fff6df</Color>
						</DataItem>
					</DataItemList>
				</DataItemGroup>
			</DataItemGroupList>
			<DataItemList>
				<DataItem type=""Date"">
					<Id>375186</Id>
					<Label>Sæt startdato for driftsstop|Set startdate for shutdown||Встановіть дату початку простою</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>1</DisplayOrder>
					<MinValue>2021-09-08</MinValue>
					<MaxValue>2031-09-08</MaxValue>
					<Value/>
					<Mandatory>false</Mandatory>
					<ReadOnly>false</ReadOnly>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Date"">
					<Id>375187</Id>
					<Label>Sæt slutdato for driftsstop|Set end date for shutdown||Встановіть кінцеву дату простою</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>2</DisplayOrder>
					<MinValue>2021-09-08</MinValue>
					<MaxValue>2031-09-08</MaxValue>
					<Value/>
					<Mandatory>false</Mandatory>
					<ReadOnly>false</ReadOnly>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Number"">
					<Id>375183</Id>
					<Label>Driftsstop timer|Downtime hours||Години простою</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>3</DisplayOrder>
					<Mandatory>false</Mandatory>
					<MinValue/>
					<MaxValue/>
					<Value/>
					<DecimalCount/>
					<UnitName/>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Comment"">
					<Id>375188</Id>
					<Label>Årsag til driftsstop|Cause of shutdown||Причина відключення</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>4</DisplayOrder>
					<Multi>1</Multi>
					<GeolocationEnabled>false</GeolocationEnabled>
					<Split>false</Split>
					<Value/>
					<ReadOnly>false</ReadOnly>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Picture"">
					<Id>375181</Id>
					<Label>Billede|Picture||Зображення</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>5</DisplayOrder>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Comment"">
					<Id>375180</Id>
					<Label>Kommentar|Comment||Коментар</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>6</DisplayOrder>
					<Multi>1</Multi>
					<GeolocationEnabled>false</GeolocationEnabled>
					<Split>false</Split>
					<Value/>
					<ReadOnly>false</ReadOnly>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""SaveButton"">
					<Id>375182</Id>
					<Label>Gem registrering|Save registration||Зберегти реєстрацію</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>7</DisplayOrder>
					<Value>GEM|SAVE||ЗБЕРЕГТИ</Value>
					<Color>f0f8db</Color>
				</DataItem>
			</DataItemList>
		</Element>
	</ElementList>
</Main>",
@"<?xml version=""1.0"" encoding=""UTF-8""?>
<Main>
	<Id>142256</Id>
	<Repeated>0</Repeated>
	<Label>09. Forsuring pH værdi|09. Acidification pH value||09. Значення рН підкислення</Label>
	<StartDate>2021-01-13</StartDate>
	<EndDate>2031-01-13</EndDate>
	<Language>da</Language>
	<MultiApproval>false</MultiApproval>
	<FastNavigation>false</FastNavigation>
	<Review>false</Review>
	<Summary>false</Summary>
	<DisplayOrder>0</DisplayOrder>
	<ElementList>
		<Element type=""DataElement"">
			<Id>142256</Id>
			<Label>09. Forsuring pH værdi|09. Acidification pH value||09. Значення рН підкислення</Label>
			<Description>
				<![CDATA[Indtast pH værdi|Enter pH value||Введіть значення pH]]>
			</Description>
			<DisplayOrder>0</DisplayOrder>
			<ReviewEnabled>false</ReviewEnabled>
			<ManualSync>false</ManualSync>
			<ExtraFieldsEnabled>false</ExtraFieldsEnabled>
			<DoneButtonDisabled>true</DoneButtonDisabled>
			<ApprovalEnabled>false</ApprovalEnabled>
			<DataItemGroupList>
				<DataItemGroup type=""FieldGroup"">
					<Id>372478</Id>
					<Label>LÆS MERE|READ MORE||ДОКЛАДНО</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>0</DisplayOrder>
					<Value>Closed</Value>
					<Color>fff6df</Color>
					<DataItemList>
						<DataItem type=""None"">
							<Id>372479</Id>
							<Label>INFO|INFO||ІНФОРМАЦІЯ</Label>
							<Description>
								<![CDATA[Bruges som ammoniakreducerende tiltag.<br><br>Hvis der er installeret forsuringsanlæg, skal man være opmærksom på vilkår om logbog, og hvad der skal registreres heri. Se miljøgodkendelsen.<br><br>Vedligeholdelse af anlægget skal følge producentens anvisninger.<br>|<br>Used as an ammonia-reducing measure.<br><br>If acidification systems have been installed, you must be aware of the terms of the logbook and what must be registered in it. See the environmental approval.<br><br>Maintenance of the system must follow the manufacturer's instructions.||<br>Використовується в якості заходу щодо зниження вмісту аміаку.<br><br>Якщо були встановлені системи підкислення, ви повинні бути інформовані про умови ведення журналу і про те, що в ньому має бути зареєстровано. Див. Екологічне схвалення.<br><br>Технічне обслуговування системи повинно здійснюватися відповідно до інструкцій виробника.]]>
							</Description>
							<DisplayOrder>0</DisplayOrder>
							<Color>fff6df</Color>
						</DataItem>
					</DataItemList>
				</DataItemGroup>
			</DataItemGroupList>
			<DataItemList>
				<DataItem type=""Number"">
					<Id>372477</Id>
					<Label>Gennemsnitlig pH-værdi i gyllen før svovlsyrebehandling|Average pH in slurry before sulfuric acid treatment||Середнє значення рН в суспензії перед обробкою сірчаною кислотою</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>1</DisplayOrder>
					<Mandatory>false</Mandatory>
					<MinValue/>
					<MaxValue/>
					<Value/>
					<DecimalCount/>
					<UnitName/>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Picture"">
					<Id>372475</Id>
					<Label>Billede|Picture||Зображення</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>4</DisplayOrder>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Comment"">
					<Id>372474</Id>
					<Label>Kommentar|Comment||Коментар</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>5</DisplayOrder>
					<Multi>1</Multi>
					<GeolocationEnabled>false</GeolocationEnabled>
					<Split>false</Split>
					<Value/>
					<ReadOnly>false</ReadOnly>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""SaveButton"">
					<Id>372476</Id>
					<Label>Gem registrering|Save registration||Зберегти реєстрацію</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>6</DisplayOrder>
					<Value>GEM|SAVE||ЗБЕРЕГТИ</Value>
					<Color>f0f8db</Color>
				</DataItem>
			</DataItemList>
		</Element>
	</ElementList>
</Main>",
@"<?xml version=""1.0"" encoding=""UTF-8""?>
<Main>
	<Id>142252</Id>
	<Repeated>0</Repeated>
	<Label>09. Forsuring serviceaftale|09. Acidification service agreement||09. Угода про надання послуг з підкислення</Label>
	<StartDate>2021-01-13</StartDate>
	<EndDate>2031-01-13</EndDate>
	<Language>da</Language>
	<MultiApproval>false</MultiApproval>
	<FastNavigation>false</FastNavigation>
	<Review>false</Review>
	<Summary>false</Summary>
	<DisplayOrder>0</DisplayOrder>
	<ElementList>
		<Element type=""DataElement"">
			<Id>142252</Id>
			<Label>09. Forsuring serviceaftale|09. Acidification service agreement||09. Угода про надання послуг з підкислення</Label>
			<Description>
				<![CDATA[Billede af serviceaftale/faktura|Picture service agreement/invoice||Зображення угоди про обслуговування/рахунок-фактура]]>
			</Description>
			<DisplayOrder>0</DisplayOrder>
			<ReviewEnabled>false</ReviewEnabled>
			<ManualSync>false</ManualSync>
			<ExtraFieldsEnabled>false</ExtraFieldsEnabled>
			<DoneButtonDisabled>true</DoneButtonDisabled>
			<ApprovalEnabled>false</ApprovalEnabled>
			<DataItemGroupList>
				<DataItemGroup type=""FieldGroup"">
					<Id>372463</Id>
					<Label>LÆS MERE|READ MORE||ДОКЛАДНО</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>0</DisplayOrder>
					<Value>Closed</Value>
					<Color>fff6df</Color>
					<DataItemList>
						<DataItem type=""None"">
							<Id>372464</Id>
							<Label>INFO|INFO||ІНФОРМАЦІЯ</Label>
							<Description>
								<![CDATA[Forsuringsanlæg skal vedligeholdes i henhold til leverandørens anvisninger, så der kan opnås de i vilkårene angivne ydelser.<br><br>Når du tager et billede af din serviceftale og/eller faktura, er den nem at finde frem på web, når du har brug for at kunne fremvise denne til f.eks. tilsynsmyndighederne.<br>|<br>Acidification systems must be maintained in accordance with the supplier's instructions so that the services specified in the terms can be obtained.<br><br>When you take a picture of your service agreement and / or invoice, it is easy to find on the web when you need to be able to present it to e.g. supervisory authorities.||<br>Системи підкислення повинні обслуговуватися відповідно до інструкцій постачальника, щоб можна було отримати послуги, зазначені в умовах.<br><br>Коли ви фотографуєте свою угоду про надання послуг та/або рахунок-фактуру, його легко знайти в Інтернеті, коли вам потрібно мати можливість представити його, наприклад, наглядовим органам.]]>
							</Description>
							<DisplayOrder>0</DisplayOrder>
							<Color>fff6df</Color>
						</DataItem>
					</DataItemList>
				</DataItemGroup>
			</DataItemGroupList>
			<DataItemList>
				<DataItem type=""Picture"">
					<Id>372462</Id>
					<Label>Billede serviceaftale|Picture service agreement||Зображення угоди про обслуговування</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>1</DisplayOrder>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Picture"">
					<Id>372460</Id>
					<Label>Billede faktura|Picture invoice||Зображення рахунку-фактури</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>4</DisplayOrder>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Comment"">
					<Id>372459</Id>
					<Label>Kommentar|Comment||Коментар</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>5</DisplayOrder>
					<Multi>1</Multi>
					<GeolocationEnabled>false</GeolocationEnabled>
					<Split>false</Split>
					<Value/>
					<ReadOnly>false</ReadOnly>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""SaveButton"">
					<Id>372461</Id>
					<Label>Gem registrering|Save registration||Зберегти реєстрацію</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>6</DisplayOrder>
					<Value>GEM|SAVE||ЗБЕРЕГТИ</Value>
					<Color>f0f8db</Color>
				</DataItem>
			</DataItemList>
		</Element>
	</ElementList>
</Main>",
@"<?xml version=""1.0"" encoding=""UTF-8""?>
<Main>
	<Id>142592</Id>
	<Repeated>0</Repeated>
	<Label>10. Varmepumpe driftsstop|10. Heat pump downtime||10. Час простою теплового насоса</Label>
	<StartDate>2021-09-08</StartDate>
	<EndDate>2031-09-08</EndDate>
	<Language>da</Language>
	<MultiApproval>false</MultiApproval>
	<FastNavigation>false</FastNavigation>
	<Review>false</Review>
	<Summary>false</Summary>
	<DisplayOrder>0</DisplayOrder>
	<ElementList>
		<Element type=""DataElement"">
			<Id>142592</Id>
			<Label>10. Varmepumpe driftsstop|10. Heat pump downtime||10. Час простою теплового насоса</Label>
			<Description>
				<![CDATA[Logbog driftsstop|Logbook downtime||Журнал часу простою]]>
			</Description>
			<DisplayOrder>0</DisplayOrder>
			<ReviewEnabled>false</ReviewEnabled>
			<ManualSync>false</ManualSync>
			<ExtraFieldsEnabled>false</ExtraFieldsEnabled>
			<DoneButtonDisabled>true</DoneButtonDisabled>
			<ApprovalEnabled>false</ApprovalEnabled>
			<DataItemGroupList>
				<DataItemGroup type=""FieldGroup"">
					<Id>375199</Id>
					<Label>LÆS MERE|READ MORE||ДОКЛАДНО</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>0</DisplayOrder>
					<Value>Closed</Value>
					<Color>fff6df</Color>
					<DataItemList>
						<DataItem type=""None"">
							<Id>375200</Id>
							<Label>INFO|INFO||ІНФОРМАЦІЯ</Label>
							<Description>
								<![CDATA[Bruges som ammoniak- og lugtreducerende tiltag i svinestalde (søer, smågrise og slagtesvin) med rørudslusning eller linespil.<br><br>Du skal være opmærksom på, om varmepumpen er med timetæller, energimåler eller en datalogger.<br><br>Hvis varmepumpen har en timetæller og/eller energimåler, bør der registreres årligt timeforbrug/energimåling for at kunne dokumentere, at varmepumpen kører jævnt.<br><br>Hvis der opstår fejl på anlægget, vil der komme en alarm på anlægget. Her skal du følge producentens anvisninger.<br><br>I miljøgodkendelsen kan der være en række vilkår til egenkontrol i forhold til den installerede miljøteknologi.<br>|<br>Used as an ammonia and odor-reducing measure in pig stables (sows, piglets and fattening pigs) with pipe release or line winch.<br><br>You must be aware of whether the heat pump has an hour meter, energy meter or a data logger.<br><br>If the heat pump has an hour meter and or energy meter, an annual consumption should be registered in order to be able to document that the heat pump runs smoothly.<br><br>If a fault occurs in the system, an alarm will sound on the system. Here you must follow the manufacturer's instructions.<br><br>In the environmental approval, there may be a number of conditions for self-inspection in relation to the installed environmental technology.<br>||<br>Використовується в якості міри по зменшенню аміаку і запаху в свинарниках (свиноматки, поросята і свині на відгодівлі) з випуском труби або лінійної лебідкою.<br><br>Ви повинні знати, чи є у теплового насоса лічильник годин, лічильник енергії або реєстратор даних.<br><br>Якщо тепловий насос оснащений годинним лічильником і/або лічильником енергії, необхідно зареєструвати річне споживання, щоб мати можливість документувати безперебійну роботу теплового насоса.<br><br>Якщо в системі відбудеться збій, в системі прозвучить сигнал тривоги. Тут ви повинні слідувати інструкціям виробника.<br><br>В екологічному твердженні може бути ряд умов для самоконтролю щодо встановленої екологічної технології.<br>]]>
							</Description>
							<DisplayOrder>0</DisplayOrder>
							<Color>fff6df</Color>
						</DataItem>
					</DataItemList>
				</DataItemGroup>
			</DataItemGroupList>
			<DataItemList>
				<DataItem type=""Date"">
					<Id>375201</Id>
					<Label>Sæt startdato for driftsstop|Set startdate for shutdown||Встановіть дату початку простою</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>1</DisplayOrder>
					<MinValue>2021-09-08</MinValue>
					<MaxValue>2031-09-08</MaxValue>
					<Value/>
					<Mandatory>false</Mandatory>
					<ReadOnly>false</ReadOnly>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Date"">
					<Id>375202</Id>
					<Label>Sæt slutdato for driftsstop|Set end date for shutdown||Встановіть кінцеву дату простою</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>2</DisplayOrder>
					<MinValue>2021-09-08</MinValue>
					<MaxValue>2031-09-08</MaxValue>
					<Value/>
					<Mandatory>false</Mandatory>
					<ReadOnly>false</ReadOnly>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Number"">
					<Id>375198</Id>
					<Label>Driftsstop timer|Downtime hours||Години простою</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>3</DisplayOrder>
					<Mandatory>false</Mandatory>
					<MinValue/>
					<MaxValue/>
					<Value/>
					<DecimalCount/>
					<UnitName/>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Comment"">
					<Id>375203</Id>
					<Label>Årsag til driftsstop|Cause of shutdown||Причина відключення</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>4</DisplayOrder>
					<Multi>1</Multi>
					<GeolocationEnabled>false</GeolocationEnabled>
					<Split>false</Split>
					<Value/>
					<ReadOnly>false</ReadOnly>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Picture"">
					<Id>375196</Id>
					<Label>Billede|Picture||Зображення</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>5</DisplayOrder>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Comment"">
					<Id>375195</Id>
					<Label>Kommentar|Comment||Коментар</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>6</DisplayOrder>
					<Multi>1</Multi>
					<GeolocationEnabled>false</GeolocationEnabled>
					<Split>false</Split>
					<Value/>
					<ReadOnly>false</ReadOnly>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""SaveButton"">
					<Id>375197</Id>
					<Label>Gem registrering|Save registration||Зберегти реєстрацію</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>7</DisplayOrder>
					<Value>GEM|SAVE||ЗБЕРЕГТИ</Value>
					<Color>f0f8db</Color>
				</DataItem>
			</DataItemList>
		</Element>
	</ElementList>
</Main>",
@"<?xml version=""1.0"" encoding=""UTF-8""?>
<Main>
	<Id>142591</Id>
	<Repeated>0</Repeated>
	<Label>10. Varmepumpe serviceaftale|10. Heat pump service agreement||10. Угода про обслуговування теплового насоса</Label>
	<StartDate>2021-09-08</StartDate>
	<EndDate>2031-09-08</EndDate>
	<Language>da</Language>
	<MultiApproval>false</MultiApproval>
	<FastNavigation>false</FastNavigation>
	<Review>false</Review>
	<Summary>false</Summary>
	<DisplayOrder>0</DisplayOrder>
	<ElementList>
		<Element type=""DataElement"">
			<Id>142591</Id>
			<Label>10. Varmepumpe serviceaftale|10. Heat pump service agreement||10. Угода про обслуговування теплового насоса</Label>
			<Description>
				<![CDATA[Billede af serviceaftale/faktura|Picture service agreement/invoice||Зображення угоди про обслуговування/рахунок-фактура]]>
			</Description>
			<DisplayOrder>0</DisplayOrder>
			<ReviewEnabled>false</ReviewEnabled>
			<ManualSync>false</ManualSync>
			<ExtraFieldsEnabled>false</ExtraFieldsEnabled>
			<DoneButtonDisabled>true</DoneButtonDisabled>
			<ApprovalEnabled>false</ApprovalEnabled>
			<DataItemGroupList>
				<DataItemGroup type=""FieldGroup"">
					<Id>375193</Id>
					<Label>LÆS MERE|READ MORE||ДОКЛАДНО</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>0</DisplayOrder>
					<Value>Closed</Value>
					<Color>fff6df</Color>
					<DataItemList>
						<DataItem type=""None"">
							<Id>375194</Id>
							<Label>INFO|INFO||ІНФОРМАЦІЯ</Label>
							<Description>
								<![CDATA[Når du tager et billede af din serviceftale og/eller faktura, er den nem at finde frem på web, når du har brug for at kunne fremvise denne til f.eks. tilsynsmyndighederne.<br>|<br>When you take a picture of your service agreement and / or invoice, it is easy to find on the web when you need to be able to present it to e.g. supervisory authorities.||<br>Коли ви фотографуєте свою угоду про надання послуг та/або рахунок-фактуру, його легко знайти в Інтернеті, коли вам потрібно мати можливість представити його, наприклад, наглядовим органам.]]>
							</Description>
							<DisplayOrder>0</DisplayOrder>
							<Color>fff6df</Color>
						</DataItem>
					</DataItemList>
				</DataItemGroup>
			</DataItemGroupList>
			<DataItemList>
				<DataItem type=""Picture"">
					<Id>375192</Id>
					<Label>Billede serviceaftale|Picture service agreement||Зображення угоди про обслуговування</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>1</DisplayOrder>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Picture"">
					<Id>375190</Id>
					<Label>Billede faktura|Picture invoice||Зображення рахунку-фактури</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>4</DisplayOrder>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Comment"">
					<Id>375189</Id>
					<Label>Kommentar|Comment||Коментар</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>5</DisplayOrder>
					<Multi>1</Multi>
					<GeolocationEnabled>false</GeolocationEnabled>
					<Split>false</Split>
					<Value/>
					<ReadOnly>false</ReadOnly>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""SaveButton"">
					<Id>375191</Id>
					<Label>Gem registrering|Save registration||Зберегти реєстрацію</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>6</DisplayOrder>
					<Value>GEM|SAVE||ЗБЕРЕГТИ</Value>
					<Color>f0f8db</Color>
				</DataItem>
			</DataItemList>
		</Element>
	</ElementList>
</Main>",
@"<?xml version=""1.0"" encoding=""UTF-8""?>
<Main>
	<Id>142445</Id>
	<Repeated>0</Repeated>
	<Label>10. Varmepumpe timer og energi|10. Heat pumps hours and energy||10. Години роботи та енергія теплових насосів</Label>
	<StartDate>2021-06-08</StartDate>
	<EndDate>2031-06-08</EndDate>
	<Language>da</Language>
	<MultiApproval>false</MultiApproval>
	<FastNavigation>false</FastNavigation>
	<Review>false</Review>
	<Summary>false</Summary>
	<DisplayOrder>0</DisplayOrder>
	<ElementList>
		<Element type=""DataElement"">
			<Id>142445</Id>
			<Label>10. Varmepumpe timer og energi|10. Heat pumps hours and energy||10. Години роботи та енергія теплових насосів</Label>
			<Description>
				<![CDATA[Timetæller, MWh og tryk|Hour meter, MWh and pressure||Лічильник годин, МВт/год і тиск]]>
			</Description>
			<DisplayOrder>0</DisplayOrder>
			<ReviewEnabled>false</ReviewEnabled>
			<ManualSync>false</ManualSync>
			<ExtraFieldsEnabled>false</ExtraFieldsEnabled>
			<DoneButtonDisabled>true</DoneButtonDisabled>
			<ApprovalEnabled>false</ApprovalEnabled>
			<DataItemGroupList>
				<DataItemGroup type=""FieldGroup"">
					<Id>374287</Id>
					<Label>LÆS MERE|READ MORE||ДОКЛАДНО</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>0</DisplayOrder>
					<Value>Closed</Value>
					<Color>fff6df</Color>
					<DataItemList>
						<DataItem type=""None"">
							<Id>374288</Id>
							<Label>INFO|INFO||ІНФОРМАЦІЯ</Label>
							<Description>
								<![CDATA[Bruges som ammoniak- og lugtreducerende tiltag i svinestalde (søer, smågrise og slagtesvin) med rørudslusning eller linespil. <br><br>Du skal være opmærksom på, om varmepumpen er med timetæller, energimåler eller en datalogger. <br><br>Hvis varmepumpen har en timetæller og/eller energimåler, bør der registreres årligt timeforbrug/energimåling for at kunne dokumentere, at varmepumpen kører jævnt. <br><br>Hvis der opstår fejl på anlægget, vil der komme en alarm på anlægget. Her skal du følge producentens anvisninger.  <br><br>I miljøgodkendelsen kan der være en række vilkår til egenkontrol i forhold til den installerede miljøteknologi.<br>|<br>Used as an ammonia and odor-reducing measure in pig stables (sows, piglets and fattening pigs) with pipe release or line winch.<br><br>You must be aware of whether the heat pump has an hour meter, energy meter or a data logger.<br><br>If the heat pump has an hour meter and or energy meter, an annual consumption should be registered in order to be able to document that the heat pump runs smoothly.<br><br>If a fault occurs in the system, an alarm will sound on the system. Here you must follow the manufacturer's instructions.<br><br>In the environmental approval, there may be a number of conditions for self-inspection in relation to the installed environmental technology.<br>||< br>Використовується в якості міри по зменшенню аміаку і запаху в свинарниках (свиноматки, поросята і свині на відгодівлі) з випуском труби або лінійної лебідкою.<br><br>Ви повинні знати, чи є у теплового насоса лічильник годин, лічильник енергії або реєстратор даних.<br><br>Якщо тепловий насос оснащений годинним лічильником і/або лічильником енергії, необхідно зареєструвати річне споживання, щоб мати можливість документувати безперебійну роботу теплового насоса.<br><br>Якщо в системі відбудеться збій, в системі прозвучить сигнал тривоги. Тут ви повинні слідувати інструкціям виробника.<br><br>В екологічному твердженні може бути ряд умов для самоконтролю щодо встановленої екологічної технології.<br>]]>
							</Description>
							<DisplayOrder>0</DisplayOrder>
							<Color>fff6df</Color>
						</DataItem>
					</DataItemList>
				</DataItemGroup>
			</DataItemGroupList>
			<DataItemList>
				<DataItem type=""Number"">
					<Id>374286</Id>
					<Label>Timetæller|Hour meter||Лічильник годин</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>1</DisplayOrder>
					<Mandatory>false</Mandatory>
					<MinValue/>
					<MaxValue/>
					<Value/>
					<DecimalCount/>
					<UnitName/>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Number"">
					<Id>374289</Id>
					<Label>Energimåling (MWh)|Energy measurement (MWh)||Вимірювання енергії (МВт/год)</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>2</DisplayOrder>
					<Mandatory>false</Mandatory>
					<MinValue/>
					<MaxValue/>
					<Value/>
					<DecimalCount/>
					<UnitName/>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>374290</Id>
					<Label>Tjek tryk|Check pressure|Перевірте тиск</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>3</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Picture"">
					<Id>374284</Id>
					<Label>Billede|Picture||Зображення</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>4</DisplayOrder>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Comment"">
					<Id>374283</Id>
					<Label>Kommentar|Comment||Коментар</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>5</DisplayOrder>
					<Multi>1</Multi>
					<GeolocationEnabled>false</GeolocationEnabled>
					<Split>false</Split>
					<Value/>
					<ReadOnly>false</ReadOnly>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""SaveButton"">
					<Id>374285</Id>
					<Label>Gem registrering|Save registration||Зберегти реєстрацію</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>6</DisplayOrder>
					<Value>GEM|SAVE||ЗБЕРЕГТИ</Value>
					<Color>f0f8db</Color>
				</DataItem>
			</DataItemList>
		</Element>
	</ElementList>
</Main>",
@"<?xml version=""1.0"" encoding=""UTF-8""?>
<Main>
	<Id>142399</Id>
	<Repeated>0</Repeated>
	<Label>11. Pillefyr|11. Pellet stove||11. Пелетна піч</Label>
	<StartDate>2021-05-19</StartDate>
	<EndDate>2031-05-19</EndDate>
	<Language>da</Language>
	<MultiApproval>false</MultiApproval>
	<FastNavigation>false</FastNavigation>
	<Review>false</Review>
	<Summary>false</Summary>
	<DisplayOrder>0</DisplayOrder>
	<ElementList>
		<Element type=""DataElement"">
			<Id>142399</Id>
			<Label>11. Pillefyr|11. Pellet stove||11. Пелетна піч</Label>
			<Description>
				<![CDATA[Aske, rengøring og mængde piller|Ash, cleaning and amount of pellets||Зола, очищення і кількість гранул]]>
			</Description>
			<DisplayOrder>0</DisplayOrder>
			<ReviewEnabled>false</ReviewEnabled>
			<ManualSync>false</ManualSync>
			<ExtraFieldsEnabled>false</ExtraFieldsEnabled>
			<DoneButtonDisabled>true</DoneButtonDisabled>
			<ApprovalEnabled>false</ApprovalEnabled>
			<DataItemList>
				<DataItem type=""CheckBox"">
					<Id>373691</Id>
					<Label>Tjek beholder til aske|Check container for ash||Перевірте контейнер на наявність золи</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>1</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>373692</Id>
					<Label>Pillefyr rengjort (hvis nødvendigt)|Pellet stove cleaned (if necessary)||Пелетна піч очищена (при необхідності)</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>2</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>373693</Id>
					<Label>Tjek silo for piller på lager|Check silo for pellets in stock||Перевірте бункер на наявність гранул на складі</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>3</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Picture"">
					<Id>373686</Id>
					<Label>Billede|Picture||Зображення</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>4</DisplayOrder>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Comment"">
					<Id>373685</Id>
					<Label>Kommentar|Comment||Коментар</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>5</DisplayOrder>
					<Multi>1</Multi>
					<GeolocationEnabled>false</GeolocationEnabled>
					<Split>false</Split>
					<Value/>
					<ReadOnly>false</ReadOnly>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""SaveButton"">
					<Id>373687</Id>
					<Label>Gem registrering|Save registration||Зберегти реєстрацію</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>6</DisplayOrder>
					<Value>GEM|SAVE||ЗБЕРЕГТИ</Value>
					<Color>f0f8db</Color>
				</DataItem>
			</DataItemList>
		</Element>
	</ElementList>
</Main>",
@"<?xml version=""1.0"" encoding=""UTF-8""?>
<Main>
	<Id>142265</Id>
	<Repeated>0</Repeated>
	<Label>12. Affald og farligt affald|12. Waste and hazardous waste||12. Відходи та небезпечні відходи</Label>
	<StartDate>2021-01-17</StartDate>
	<EndDate>2031-01-17</EndDate>
	<Language>da</Language>
	<MultiApproval>false</MultiApproval>
	<FastNavigation>false</FastNavigation>
	<Review>false</Review>
	<Summary>false</Summary>
	<DisplayOrder>0</DisplayOrder>
	<ElementList>
		<Element type=""DataElement"">
			<Id>142265</Id>
			<Label>12. Affald og farligt affald|12. Waste and hazardous waste||12. Відходи та небезпечні відходи</Label>
			<Description>
				<![CDATA[Dokumentation af korrekt bortskaffelse|Documentation of proper disposal||Документація про належну утилізацію]]>
			</Description>
			<DisplayOrder>0</DisplayOrder>
			<ReviewEnabled>false</ReviewEnabled>
			<ManualSync>false</ManualSync>
			<ExtraFieldsEnabled>false</ExtraFieldsEnabled>
			<DoneButtonDisabled>true</DoneButtonDisabled>
			<ApprovalEnabled>false</ApprovalEnabled>
			<DataItemGroupList>
				<DataItemGroup type=""FieldGroup"">
					<Id>372544</Id>
					<Label>LÆS MERE|READ MORE||ДОКЛАДНО</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>0</DisplayOrder>
					<Value>Closed</Value>
					<Color>fff6df</Color>
					<DataItemList>
						<DataItem type=""None"">
							<Id>372545</Id>
							<Label>INFO|INFO||ІНФОРМАЦІЯ</Label>
							<Description>
								<![CDATA[Kommunens erhvervsaffaldsregulativ skal følges.&nbsp;<br><br>Det skal til en hver tid kunne dokumenteres, hvordan affald er blevet bortskaffet. Fx i form af kvitteringer fra skrothandler, genbrugsplads eller lignende.<br><br>For farligt affald skal der være særlig opmærksomhed på opbevaringen indtil bortskaffelse, så det sikres, at der ikke sker miljøbelastning.<br>&nbsp;<br>Opbevaringen af døde dyr må ikke give anledning til uhygiejniske forhold eller risiko for forurening af jord, grundvand eller overfladevand.<br>|<br>The municipality's commercial waste regulations must be followed.<br><br>It must always be possible to document how waste has been disposed of. For example in the form of receipts from scrap dealers, recycling sites or the like.<br><br>For hazardous waste, special attention must be paid to storage until disposal to ensure that there is no environmental impact.<br><br>The storage of dead animals must not give rise to unhygienic conditions or the risk of contamination of soil, groundwater or surface water.<br>||<br>Необхідно дотримуватися муніципальних правил поводження з комерційними відходами.<br><br>Завжди повинна бути можливість документувати, як були утилізовані відходи. Наприклад, у вигляді квитанцій від торговців металобрухтом, місць переробки і т.п.<br><br>Для небезпечних відходів особлива увага повинна приділятися зберіганню до утилізації, щоб гарантувати відсутність впливу на навколишнє середовище.<br><br>Зберігання мертвих тварин не повинно призводити до виникнення негігієнічних умов або ризику забруднення грунту, грунтових або поверхневих вод.<br>]]>
							</Description>
							<DisplayOrder>0</DisplayOrder>
							<Color>fff6df</Color>
						</DataItem>
					</DataItemList>
				</DataItemGroup>
			</DataItemGroupList>
			<DataItemList>
				<DataItem type=""Picture"">
					<Id>372541</Id>
					<Label>Billede kvittering|Picture receipts||Фотографії з квитанціями</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>1</DisplayOrder>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Comment"">
					<Id>372540</Id>
					<Label>Kommentar|Comment||Коментар</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>4</DisplayOrder>
					<Multi>1</Multi>
					<GeolocationEnabled>false</GeolocationEnabled>
					<Split>false</Split>
					<Value/>
					<ReadOnly>false</ReadOnly>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""SaveButton"">
					<Id>372542</Id>
					<Label>Gem registrering|Save registration||Зберегти реєстрацію</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>5</DisplayOrder>
					<Value>GEM|SAVE||ЗБЕРЕГТИ</Value>
					<Color>f0f8db</Color>
				</DataItem>
			</DataItemList>
		</Element>
	</ElementList>
</Main>",
@"<?xml version=""1.0"" encoding=""UTF-8""?>
<Main>
	<Id>142262</Id>
	<Repeated>0</Repeated>
	<Label>12. Dieseltank|12. Diesel tank||12. Дизельний бак</Label>
	<StartDate>2021-01-17</StartDate>
	<EndDate>2031-01-17</EndDate>
	<Language>da</Language>
	<MultiApproval>false</MultiApproval>
	<FastNavigation>false</FastNavigation>
	<Review>false</Review>
	<Summary>false</Summary>
	<DisplayOrder>0</DisplayOrder>
	<ElementList>
		<Element type=""DataElement"">
			<Id>142262</Id>
			<Label>12. Dieseltank|12. Diesel tank||12. Дизельний бак</Label>
			<Description>
				<![CDATA[Kontrolpunkter dieseltank|Checkpoints diesel tank||Контроль дизельного баку]]>
			</Description>
			<DisplayOrder>0</DisplayOrder>
			<ReviewEnabled>false</ReviewEnabled>
			<ManualSync>false</ManualSync>
			<ExtraFieldsEnabled>false</ExtraFieldsEnabled>
			<DoneButtonDisabled>true</DoneButtonDisabled>
			<ApprovalEnabled>false</ApprovalEnabled>
			<DataItemGroupList>
				<DataItemGroup type=""FieldGroup"">
					<Id>372518</Id>
					<Label>LÆS MERE|READ MORE||ДОКЛАДНО</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>0</DisplayOrder>
					<Value>Closed</Value>
					<Color>fff6df</Color>
					<DataItemList>
						<DataItem type=""None"">
							<Id>372519</Id>
							<Label>INFO|INFO||ІНФОРМАЦІЯ</Label>
							<Description>
								<![CDATA[Opbevaring af dieselolie skal ske i godkendte tanke. Tankene skal være placeret, så risiko for påkørsel minimeres, og så eventuelt spild kan opsamles eller håndteres uden risiko for afstrømning til det omkringliggende miljø.<br><br>Slanger og tankhaner skal være tætte og alle tanke skal være registreret i BBR. Der skal desuden være tankattest og læsbar mærkat med tanktype og alder.&nbsp;<br><br>Et olieabsorberende materiale, eksempelvis kattegrus, skal til enhver tid være let tilgængeligt i umiddelbar nærhed af alle ejendommens&nbsp; dieseltanke, således at spild omgående og effektivt kan opsamles.<br>|<br>Storage of diesel oil must take place in approved tanks. The tanks must be located so that the risk of collision is minimized, and so that any waste can be collected or handled without risk of run-off to the surrounding environment.<br><br>Hoses and tank valves must be tight and all tanks must be registered in the BBR. There must be a tank certificate and a legible sticker with tank type and age.<br><br>An oil-absorbent material, such as cat litter, must at all times be easily accessible in the immediate vicinity of all the property's diesel tanks, so that spills can be collected immediately and efficiently.||<br>Зберігання дизельного палива повинно здійснюватися в затверджених резервуарах. Резервуари повинні бути розташовані таким чином, щоб ризик зіткнення був зведений до мінімуму, і щоб будь-які відходи можна було збирати або обробляти без ризику потрапляння в навколишнє середовище.<br><br>Шланги та клапани резервуарів повинні бути герметичними, і всі резервуари повинні бути зареєстровані в BBR. Повинен бути сертифікат бака і розбірлива наклейка з типом бака і віком.<br><br>Маслопоглинаючий матеріал, такий як наповнювач для котячого туалету, завжди повинен бути легко доступний в безпосередній близькості від всіх дизельних баків, щоб розливи могли бути зібрані негайно і ефективно.]]>
							</Description>
							<DisplayOrder>0</DisplayOrder>
							<Color>fff6df</Color>
						</DataItem>
					</DataItemList>
				</DataItemGroup>
			</DataItemGroupList>
			<DataItemList>
				<DataItem type=""CheckBox"">
					<Id>372517</Id>
					<Label>Tankattest OK|Tank certificate OK||Сертифікат резервуара в порядку</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>1</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>372520</Id>
					<Label>Ingen spild og utætheder|No spills and leaks||Ніяких розливів і витоків</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>2</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>372521</Id>
					<Label>Slange til diesel OK|Hose for diesel OK||Шланг для дизельного палива в порядку</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>3</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>372522</Id>
					<Label>Adgang til olieabsorberende materiale|Access to oil absorbent material||Доступ до маслопоглинаючого матеріалу</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>4</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Picture"">
					<Id>372515</Id>
					<Label>Billede|Picture||Зображення</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>5</DisplayOrder>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Comment"">
					<Id>372514</Id>
					<Label>Kommentar|Comment||Коментар</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>6</DisplayOrder>
					<Multi>1</Multi>
					<GeolocationEnabled>false</GeolocationEnabled>
					<Split>false</Split>
					<Value/>
					<ReadOnly>false</ReadOnly>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""SaveButton"">
					<Id>372516</Id>
					<Label>Gem registrering|Save registration||Зберегти реєстрацію</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>7</DisplayOrder>
					<Value>GEM|SAVE||ЗБЕРЕГТИ</Value>
					<Color>f0f8db</Color>
				</DataItem>
			</DataItemList>
		</Element>
	</ElementList>
</Main>",
@"<?xml version=""1.0"" encoding=""UTF-8""?>
<Main>
	<Id>142264</Id>
	<Repeated>0</Repeated>
	<Label>12. Kemi|12. Chemistry||12. Хімія</Label>
	<StartDate>2021-01-17</StartDate>
	<EndDate>2031-01-17</EndDate>
	<Language>da</Language>
	<MultiApproval>false</MultiApproval>
	<FastNavigation>false</FastNavigation>
	<Review>false</Review>
	<Summary>false</Summary>
	<DisplayOrder>0</DisplayOrder>
	<ElementList>
		<Element type=""DataElement"">
			<Id>142264</Id>
			<Label>12. Kemi|12. Chemistry||12. Хімія</Label>
			<Description>
				<![CDATA[Kontrolpunkter kemi|Checkpoints chemistry||Контроль хімії]]>
			</Description>
			<DisplayOrder>0</DisplayOrder>
			<ReviewEnabled>false</ReviewEnabled>
			<ManualSync>false</ManualSync>
			<ExtraFieldsEnabled>false</ExtraFieldsEnabled>
			<DoneButtonDisabled>true</DoneButtonDisabled>
			<ApprovalEnabled>false</ApprovalEnabled>
			<DataItemGroupList>
				<DataItemGroup type=""FieldGroup"">
					<Id>372536</Id>
					<Label>LÆS MERE|READ MORE||ДОКЛАДНО</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>0</DisplayOrder>
					<Value>Closed</Value>
					<Color>fff6df</Color>
					<DataItemList>
						<DataItem type=""None"">
							<Id>372537</Id>
							<Label>INFO|INFO||ІНФОРМАЦІЯ</Label>
							<Description>
								<![CDATA[Pesticider skal altid opbevares utilgængeligt for uvedkommende - altså bag lås.&nbsp;Pesticider skal være godkendte og forsynet med dansk etikette.<br>&nbsp;<br>Der må ikke være afløb i gulvet, hvor pesticider opbevares.<br><br>Vejledning om værnemidler og korrekt anvendelse skal være tilgængelig. Værnemidler skal være tilgængelige.<br>|<br>Pesticides must always be kept out of the reach of unauthorized persons - ie behind locks. Pesticides must be approved and provided with Danish etiquette.<br><br>There must be no drains in the floor where pesticides are stored.<br><br>Guidance on protective equipment and proper use must be available. Protective equipment must be available.||<br>Пестициди завжди повинні зберігатися в недоступному для сторонніх осіб місці - тобто за замками. Пестициди повинні бути схвалені та забезпечені датським етикетом.<br><br>На підлозі, де зберігаються пестициди, не повинно бути стоків.<br><br>Має бути доступне керівництво по захисному обладнанню і правильному використанню. Має бути в наявності захисне спорядження.]]>
							</Description>
							<DisplayOrder>0</DisplayOrder>
							<Color>fff6df</Color>
						</DataItem>
					</DataItemList>
				</DataItemGroup>
			</DataItemGroupList>
			<DataItemList>
				<DataItem type=""CheckBox"">
					<Id>373365</Id>
					<Label>Kemitjek|Chemistry check||Перевірка хімії</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>1</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>372538</Id>
					<Label>Ingen spild og utætte beholdere|No spills and leaky containers||Ніяких розливів і протікаючих контейнерів</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>2</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>372539</Id>
					<Label>Værnemidler tilgængelig|Protective equipment available||Наявне захисне спорядження</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>3</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Picture"">
					<Id>372533</Id>
					<Label>Billede|Picture||Зображення</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>4</DisplayOrder>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Comment"">
					<Id>372532</Id>
					<Label>Kommentar|Comment||Коментар</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>5</DisplayOrder>
					<Multi>1</Multi>
					<GeolocationEnabled>false</GeolocationEnabled>
					<Split>false</Split>
					<Value/>
					<ReadOnly>false</ReadOnly>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""SaveButton"">
					<Id>372534</Id>
					<Label>Gem registrering|Save registration||Зберегти реєстрацію</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>6</DisplayOrder>
					<Value>GEM|SAVE||ЗБЕРЕГТИ</Value>
					<Color>f0f8db</Color>
				</DataItem>
			</DataItemList>
		</Element>
	</ElementList>
</Main>",
@"<?xml version=""1.0"" encoding=""UTF-8""?>
<Main>
	<Id>142263</Id>
	<Repeated>0</Repeated>
	<Label>12. Motor- og spildolie|12. Motor oil and waste oil||12. Моторне масло і відпрацьоване масло</Label>
	<StartDate>2021-01-17</StartDate>
	<EndDate>2031-01-17</EndDate>
	<Language>da</Language>
	<MultiApproval>false</MultiApproval>
	<FastNavigation>false</FastNavigation>
	<Review>false</Review>
	<Summary>false</Summary>
	<DisplayOrder>0</DisplayOrder>
	<ElementList>
		<Element type=""DataElement"">
			<Id>142263</Id>
			<Label>12. Motor- og spildolie|12. Motor oil and waste oil||12. Моторне масло і відпрацьоване масло</Label>
			<Description>
				<![CDATA[Kontrolpunkter motor- og spildolie|Checkpoints motor oil and waste oil||Контроль моторного мастила і відпрацьованого мастила]]>
			</Description>
			<DisplayOrder>0</DisplayOrder>
			<ReviewEnabled>false</ReviewEnabled>
			<ManualSync>false</ManualSync>
			<ExtraFieldsEnabled>false</ExtraFieldsEnabled>
			<DoneButtonDisabled>true</DoneButtonDisabled>
			<ApprovalEnabled>false</ApprovalEnabled>
			<DataItemGroupList>
				<DataItemGroup type=""FieldGroup"">
					<Id>372527</Id>
					<Label>LÆS MERE|READ MORE||ДОКЛАДНО</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>0</DisplayOrder>
					<Value>Closed</Value>
					<Color>fff6df</Color>
					<DataItemList>
						<DataItem type=""None"">
							<Id>372528</Id>
							<Label>INFO|INFO||ІНФОРМАЦІЯ</Label>
							<Description>
								<![CDATA[Opbevaring af både spildolie og ny motorolie skal ske i dertil egnede beholdere.&nbsp;Alle beholdere skal være placeret på fast gulv uden afløb.&nbsp;<br><br>Beholdere kan være placeret i spildbakke eller lignende, der som minimum kan rumme indholdet af den største beholder.<br><br>Bortskaffelse af spildolie, filtre mm. skal ske efter gældende regler og skal kunne dokumenteres.<br><br>Spildolie ikke må anvendes til smøring etc.<br><br>Vær opmærksom på kommunernes erhvervsaffaldsregulativ i forbindelse med fx bortskaffelseshyppighed mv.&nbsp;<br>|<br>Both waste oil and new engine oil must be stored in suitable containers. All containers must be placed on a solid floor without a drain.<br><br>Containers can be placed in a waste bin or similar, which can at least hold the contents of the largest container.<br><br>Disposal of waste oil, filters etc. must be done according to current rules and must be able to be documented.<br><br>Waste oil must not be used for lubrication etc.<br><br>Pay attention to the municipalities' commercial waste regulations in connection with, for example, disposal frequency, etc.||<br>Як відпрацьоване масло, так і нове моторне масло повинні зберігатися у відповідних контейнерах. Всі контейнери повинні бути розміщені на твердій підлозі без зливу.<br><br>Контейнери можуть бути поміщені у відро для сміття або аналогічне, яке може, принаймні, вмістити вміст найбільшого контейнера.<br><br>Утилізація відпрацьованого масла, фільтрів і т.д. повинна проводитися відповідно до діючих правил і повинна бути документована.<br><br>Відпрацьоване масло не повинно використовуватися для змащення і т. д.<br><br>Зверніть увагу на муніципальні правила щодо комерційних відходів у зв'язку, наприклад, з частотою утилізації і т. д.]]>
							</Description>
							<DisplayOrder>0</DisplayOrder>
							<Color>fff6df</Color>
						</DataItem>
					</DataItemList>
				</DataItemGroup>
			</DataItemGroupList>
			<DataItemList>
				<DataItem type=""CheckBox"">
					<Id>372526</Id>
					<Label>Tankattest OK|Tank certificate OK||Сертифікат резервуара в порядку</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>1</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>372529</Id>
					<Label>Ingen spild og utætheder|No spills and leaks||Ніяких розливів і витоків</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>2</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>372531</Id>
					<Label>Adgang til olieabsorberende materiale|Access to oil absorbent material||Доступ до маслопоглинаючого матеріалу</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>4</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Picture"">
					<Id>372524</Id>
					<Label>Billede|Picture||Зображення</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>5</DisplayOrder>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Comment"">
					<Id>372523</Id>
					<Label>Kommentar|Comment||Коментар</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>6</DisplayOrder>
					<Multi>1</Multi>
					<GeolocationEnabled>false</GeolocationEnabled>
					<Split>false</Split>
					<Value/>
					<ReadOnly>false</ReadOnly>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""SaveButton"">
					<Id>372525</Id>
					<Label>Gem registrering|Save registration||Зберегти реєстрацію</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>7</DisplayOrder>
					<Value>GEM|SAVE||ЗБЕРЕГТИ</Value>
					<Color>f0f8db</Color>
				</DataItem>
			</DataItemList>
		</Element>
	</ElementList>
</Main>",
@"<?xml version=""1.0"" encoding=""UTF-8""?>
<Main>
	<Id>142196</Id>
	<Repeated>0</Repeated>
	<Label>13. APV Medarbejder|13. WPA Worker||13. ОРМ Працівника</Label>
	<StartDate>2020-12-04</StartDate>
	<EndDate>2030-12-04</EndDate>
	<Language>da</Language>
	<MultiApproval>false</MultiApproval>
	<FastNavigation>false</FastNavigation>
	<Review>false</Review>
	<Summary>false</Summary>
	<DisplayOrder>0</DisplayOrder>
	<ElementList>
		<Element type=""DataElement"">
			<Id>142196</Id>
			<Label>13. APV Medarbejder|13. WPA Worker||13. ОРМ Працівника</Label>
			<Description>
				<![CDATA[Tryk for at udfylde arbejdspladsvurdering (APV)<br>|<br>Press to complete workplace assessment (WPA)<br>||<br>Натисніть, щоб завершити оцінку робочого місця (ОРМ)<br>]]>
			</Description>
			<DisplayOrder>0</DisplayOrder>
			<ReviewEnabled>false</ReviewEnabled>
			<ManualSync>false</ManualSync>
			<ExtraFieldsEnabled>false</ExtraFieldsEnabled>
			<DoneButtonDisabled>true</DoneButtonDisabled>
			<ApprovalEnabled>false</ApprovalEnabled>
			<DataItemList>
				<DataItem type=""SingleSelect"">
					<Id>372091</Id>
					<Label>01. Fald til lavere niveau|01. Fall to lower level||01. Падіння на нижчий рівень</Label>
					<Description>
						<![CDATA[Er der risiko for, at I kan falde ned fra fx stiger, plansiloer, gallerier eller bygningen?<br>|<br>Is there a risk that you may fall from ladders, plan silos, galleries or the building?|<br>Чи є ризик, що ви можете впасти зі сходів, планувальних шахт, галерей або будівлі?]]>
					</Description>
					<DisplayOrder>0</DisplayOrder>
					<Mandatory>false</Mandatory>
					<KeyValuePairList>
						<KeyValuePair>
							<Key>1</Key>
							<Value>
								<![CDATA[I høj grad|Very much||Дуже сильно]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>1</DisplayOrder>
						</KeyValuePair>
						<KeyValuePair>
							<Key>2</Key>
							<Value>
								<![CDATA[I mindre grad|Not so much||Не так вже й багато]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>2</DisplayOrder>
						</KeyValuePair>
						<KeyValuePair>
							<Key>3</Key>
							<Value>
								<![CDATA[Slet ikke|Not at all||Анітрохи]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>3</DisplayOrder>
						</KeyValuePair>
					</KeyValuePairList>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""SingleSelect"">
					<Id>372092</Id>
					<Label>02. Ulykker med maskiner|02. Accidents with machines||02. Нещасні випадки з машинами(автоматами, верстатами)</Label>
					<Description>
						<![CDATA[Er der risiko for at komme til skade med de maskiner, I bruger til fx høst, fodertilberedning eller gyllehåndtering?<br>|<br>Is there a risk of injury with the machines you use for eg harvesting, feed preparation or slurry handling?||<br>Чи існує ризик отримання травм з машинами, які ви використовуєте, наприклад, для збирання врожаю, приготування кормів або обробки гнойової рідини?]]>
					</Description>
					<DisplayOrder>1</DisplayOrder>
					<Mandatory>false</Mandatory>
					<KeyValuePairList>
						<KeyValuePair>
							<Key>1</Key>
							<Value>
								<![CDATA[I høj grad|Very much||Дуже сильно]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>1</DisplayOrder>
						</KeyValuePair>
						<KeyValuePair>
							<Key>2</Key>
							<Value>
								<![CDATA[I mindre grad|Not so much||Не так вже й багато]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>2</DisplayOrder>
						</KeyValuePair>
						<KeyValuePair>
							<Key>3</Key>
							<Value>
								<![CDATA[Slet ikke|Not at all||Анітрохи]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>3</DisplayOrder>
						</KeyValuePair>
					</KeyValuePairList>
					<Color>e2f4fb</Color>
				</DataItem>
				<DataItem type=""SingleSelect"">
					<Id>372093</Id>
					<Label>03. Akut fysisk overbelastning|03. Acute physical overload||03. Гостре фізичне перевантаження</Label>
					<Description>
						<![CDATA[Er der risiko for akut overbelastning af kroppen, når I løfter, driver med dyr, trækker eller skubber fx kalve og&nbsp;grise eller tunge materialer på bedriften?<br>|<br>Is there a risk of acute overload of the body when you lift, drive animals, pull or push eg calves and pigs or heavy materials on the farm?||<br>Чи існує ризик гострого перевантаження організму, коли ви піднімаєте, водите тварин, тягнете або штовхаєте, наприклад, телят і свиней або важкі матеріали на фермі?]]>
					</Description>
					<DisplayOrder>2</DisplayOrder>
					<Mandatory>false</Mandatory>
					<KeyValuePairList>
						<KeyValuePair>
							<Key>1</Key>
							<Value>
								<![CDATA[I høj grad|Very much||Дуже сильно]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>1</DisplayOrder>
						</KeyValuePair>
						<KeyValuePair>
							<Key>2</Key>
							<Value>
								<![CDATA[I mindre grad|Not so much||Не так вже й багато]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>2</DisplayOrder>
						</KeyValuePair>
						<KeyValuePair>
							<Key>3</Key>
							<Value>
								<![CDATA[Slet ikke|Not at all||Анітрохи]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>3</DisplayOrder>
						</KeyValuePair>
					</KeyValuePairList>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""SingleSelect"">
					<Id>372094</Id>
					<Label>04. Fald og snublen|04. Fall and stumble||04. Впасти і спіткнутися</Label>
					<Description>
						<![CDATA[Er der risiko for, at I kan falde eller snuble over fx rod eller paller i stalden, laden, maskinhuset eller udendørs,&nbsp;eller fordi der er glat på plansiloen, i stalden eller udendørs?<br>|<br>Is there a risk that you may fall or stumble over, for example, clutter or pallets in the barn, barn, machine house or outdoors, or because it is slippery on the flat silo, in the barn or outdoors?||<br>Чи є ризик, що ви можете впасти або спіткнутися, наприклад, про безлад або піддони в сараї, сарай, машинному відділенні або на вулиці, або тому, що на плоскому бункері, в сараї або на вулиці слизько?]]>
					</Description>
					<DisplayOrder>3</DisplayOrder>
					<Mandatory>false</Mandatory>
					<KeyValuePairList>
						<KeyValuePair>
							<Key>1</Key>
							<Value>
								<![CDATA[I høj grad|Very much||Дуже сильно]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>1</DisplayOrder>
						</KeyValuePair>
						<KeyValuePair>
							<Key>2</Key>
							<Value>
								<![CDATA[I mindre grad|Not so much||Не так вже й багато]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>2</DisplayOrder>
						</KeyValuePair>
						<KeyValuePair>
							<Key>3</Key>
							<Value>
								<![CDATA[Slet ikke|Not at all||Анітрохи]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>3</DisplayOrder>
						</KeyValuePair>
					</KeyValuePairList>
					<Color>e2f4fb</Color>
				</DataItem>
				<DataItem type=""SingleSelect"">
					<Id>372095</Id>
					<Label>05. Ulykker med håndværktøj og håndmaskiner|05. Accidents with hand tools and hand machines||05. Нещасні випадки з ручними інструментами та ручними машинами</Label>
					<Description>
						<![CDATA[Er der risiko for at skære sig eller at få fingrene i klemme, når I arbejder med håndværktøj som fx kanyler,&nbsp;boltpistoler, motorsave, vinkelslibere og boremaskiner?<br>|<br>Is there a risk of cutting yourself or getting your fingers pinched when working with hand tools such as needles, bolt guns, chainsaws, angle grinders and drills?||<br>Чи є ризик порізати або затиснути пальці при роботі з ручними інструментами, такими як голки, болторізи, бензопили, кутові шліфувальні машини і дрилі?]]>
					</Description>
					<DisplayOrder>4</DisplayOrder>
					<Mandatory>false</Mandatory>
					<KeyValuePairList>
						<KeyValuePair>
							<Key>1</Key>
							<Value>
								<![CDATA[I høj grad|Very much||Дуже сильно]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>1</DisplayOrder>
						</KeyValuePair>
						<KeyValuePair>
							<Key>2</Key>
							<Value>
								<![CDATA[I mindre grad|Not so much||Не так вже й багато]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>2</DisplayOrder>
						</KeyValuePair>
						<KeyValuePair>
							<Key>3</Key>
							<Value>
								<![CDATA[Slet ikke|Not at all||Анітрохи]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>3</DisplayOrder>
						</KeyValuePair>
					</KeyValuePairList>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""SingleSelect"">
					<Id>372096</Id>
					<Label>06. Intern færdsel|06. Internal traffic||06. Внутрішній трафік</Label>
					<Description>
						<![CDATA[Er der risiko for, at I kan blive påkørt eller klemt af fx traktorer, knækstyrede frontlæssere og fladvogne, når I&nbsp;kører på ejendommen?<br>|<br>Is there a risk that you may be hit or crushed by eg tractors, articulated front loaders and flatbed trucks when driving on the property?||<br>Чи існує ризик того, що вас можуть збити або розчавити, наприклад, Трактори, зчленовані фронтальні навантажувачі і бортові вантажівки при русі по території?]]>
					</Description>
					<DisplayOrder>5</DisplayOrder>
					<Mandatory>false</Mandatory>
					<KeyValuePairList>
						<KeyValuePair>
							<Key>1</Key>
							<Value>
								<![CDATA[I høj grad|Very much||Дуже сильно]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>1</DisplayOrder>
						</KeyValuePair>
						<KeyValuePair>
							<Key>2</Key>
							<Value>
								<![CDATA[I mindre grad|Not so much||Не так вже й багато]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>2</DisplayOrder>
						</KeyValuePair>
						<KeyValuePair>
							<Key>3</Key>
							<Value>
								<![CDATA[Slet ikke|Not at all||Анітрохи]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>3</DisplayOrder>
						</KeyValuePair>
					</KeyValuePairList>
					<Color>e2f4fb</Color>
				</DataItem>
				<DataItem type=""SingleSelect"">
					<Id>372097</Id>
					<Label>07. Dårlige arbejdsstillinger|07. Poor working positions||07. Погані робочі місця</Label>
					<Description>
						<![CDATA[Arbejder I med foroverbøjet ryg, løftede arme, på hug eller i andre dårlige arbejdsstillinger, eller står og går I det&nbsp;meste af arbejdsdagen?<br>|<br>Do you work with your back bent, your arms raised, squatting or in other bad working positions, or do you stand and walk most of the working day?||<br>Ви працюєте зі зігнутою спиною, піднятими руками, сидячи навпочіпки або в інших поганих робочих позах, або ви стоїте і ходите більшу частину робочого дня?]]>
					</Description>
					<DisplayOrder>6</DisplayOrder>
					<Mandatory>false</Mandatory>
					<KeyValuePairList>
						<KeyValuePair>
							<Key>1</Key>
							<Value>
								<![CDATA[I høj grad|Very much||Дуже сильно]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>1</DisplayOrder>
						</KeyValuePair>
						<KeyValuePair>
							<Key>2</Key>
							<Value>
								<![CDATA[I mindre grad|Not so much||Не так вже й багато]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>2</DisplayOrder>
						</KeyValuePair>
						<KeyValuePair>
							<Key>3</Key>
							<Value>
								<![CDATA[Slet ikke|Not at all||Анітрохи]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>3</DisplayOrder>
						</KeyValuePair>
					</KeyValuePairList>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""SingleSelect"">
					<Id>372098</Id>
					<Label>08. Ensidigt, belastende arbejde|08. One-sided, stressful work||08. Одностороння, напружена робота</Label>
					<Description>
						<![CDATA[Belaster I kroppen på samme måde over længere tid – fx når I udfører pløjning med drejet nakke, kastrerer&nbsp;mange smågrise, eller aftørrer og afrenser yvere?<br>|<br>Do you strain your body in the same way for a long time - for example when you plow with a twisted neck, castrate many piglets, or wipe and clean udders?||<br>Ви довго напружуєте своє тіло таким же чином-наприклад, коли ви орете з викривленою шиєю , каструєте багато поросят або витираєте і чистите вим'я?]]>
					</Description>
					<DisplayOrder>7</DisplayOrder>
					<Mandatory>false</Mandatory>
					<KeyValuePairList>
						<KeyValuePair>
							<Key>1</Key>
							<Value>
								<![CDATA[I høj grad|Very much||Дуже сильно]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>1</DisplayOrder>
						</KeyValuePair>
						<KeyValuePair>
							<Key>2</Key>
							<Value>
								<![CDATA[I mindre grad|Not so much||Не так вже й багато]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>2</DisplayOrder>
						</KeyValuePair>
						<KeyValuePair>
							<Key>3</Key>
							<Value>
								<![CDATA[Slet ikke|Not at all||Анітрохи]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>3</DisplayOrder>
						</KeyValuePair>
					</KeyValuePairList>
					<Color>e2f4fb</Color>
				</DataItem>
				<DataItem type=""SingleSelect"">
					<Id>372099</Id>
					<Label>09. Tunge løft|09. Heavy lifting||09. Важка атлетика</Label>
					<Description>
						<![CDATA[Løfter I sække med foder, maskindele, kalve eller andre tunge emner på bedriften?<br>|<br>Do you lift sacks of feed, machine parts, calves or other heavy items on the farm?||<br>Чи піднімаєте ви мішки з кормом, деталі машин, телят або інші важкі предмети на фермі?]]>
					</Description>
					<DisplayOrder>8</DisplayOrder>
					<Mandatory>false</Mandatory>
					<KeyValuePairList>
						<KeyValuePair>
							<Key>1</Key>
							<Value>
								<![CDATA[I høj grad|Very much||Дуже сильно]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>1</DisplayOrder>
						</KeyValuePair>
						<KeyValuePair>
							<Key>2</Key>
							<Value>
								<![CDATA[I mindre grad|Not so much||Не так вже й багато]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>2</DisplayOrder>
						</KeyValuePair>
						<KeyValuePair>
							<Key>3</Key>
							<Value>
								<![CDATA[Slet ikke|Not at all||Анітрохи]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>3</DisplayOrder>
						</KeyValuePair>
					</KeyValuePairList>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""SingleSelect"">
					<Id>372100</Id>
					<Label>10. Træk og skub|10. Pull and push||10. Тягніть і штовхайте</Label>
					<Description>
						<![CDATA[Bruger I mange kræfter, når I skal trække eller skubbe fx tunge trillebøre, fodervogne, palleløftere eller&nbsp;kadavervogne?<br>|<br>Do you use a lot of force when you have to pull or push, for example, heavy wheelbarrows, feed carts, pallet trucks or carcass carts?||<br>Ви використовуєте багато сили, коли вам доводиться тягнути або штовхати, наприклад, важкі тачки, Візки для корму, Візки для піддонів або візки для туш?]]>
					</Description>
					<DisplayOrder>9</DisplayOrder>
					<Mandatory>false</Mandatory>
					<KeyValuePairList>
						<KeyValuePair>
							<Key>1</Key>
							<Value>
								<![CDATA[I høj grad|Very much||Дуже сильно]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>1</DisplayOrder>
						</KeyValuePair>
						<KeyValuePair>
							<Key>2</Key>
							<Value>
								<![CDATA[I mindre grad|Not so much||Не так вже й багато]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>2</DisplayOrder>
						</KeyValuePair>
						<KeyValuePair>
							<Key>3</Key>
							<Value>
								<![CDATA[Slet ikke|Not at all||Анітрохи]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>3</DisplayOrder>
						</KeyValuePair>
					</KeyValuePairList>
					<Color>e2f4fb</Color>
				</DataItem>
				<DataItem type=""SingleSelect"">
					<Id>372101</Id>
					<Label>11. Høj støj|11. Loud noise||11. Гучний шум</Label>
					<Description>
						<![CDATA[Arbejder I med vinkelslibere, motorsave og højtryksrensere eller andre meget støjende maskiner?<br>|<br>Do you work with angle grinders, chainsaws and high pressure cleaners or other very noisy machines?||<br>Чи працюєте ви з кутошліфувальними машинами, бензопилами, очищувачами високого тиску або іншими дуже гучними машинами?]]>
					</Description>
					<DisplayOrder>10</DisplayOrder>
					<Mandatory>false</Mandatory>
					<KeyValuePairList>
						<KeyValuePair>
							<Key>1</Key>
							<Value>
								<![CDATA[I høj grad|Very much||Дуже сильно]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>1</DisplayOrder>
						</KeyValuePair>
						<KeyValuePair>
							<Key>2</Key>
							<Value>
								<![CDATA[I mindre grad|Not so much||Не так вже й багато]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>2</DisplayOrder>
						</KeyValuePair>
						<KeyValuePair>
							<Key>3</Key>
							<Value>
								<![CDATA[Slet ikke|Not at all||Анітрохи]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>3</DisplayOrder>
						</KeyValuePair>
					</KeyValuePairList>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""SingleSelect"">
					<Id>372102</Id>
					<Label>12. Stor arbejdsmængde, tidspres og uklare krav|12. Large workload, time pressure and unclear requirements||12. Велике робоче навантаження, брак часу і неясні вимоги</Label>
					<Description>
						<![CDATA[Har I ofte for mange opgaver eller for travlt i bedriften?<br>|<br>Do you often have too many tasks or too busy on the farm?||<br>У вас часто буває занадто багато справ або ви занадто зайняті на фермі?]]>
					</Description>
					<DisplayOrder>11</DisplayOrder>
					<Mandatory>false</Mandatory>
					<KeyValuePairList>
						<KeyValuePair>
							<Key>1</Key>
							<Value>
								<![CDATA[I høj grad|Very much||Дуже сильно]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>1</DisplayOrder>
						</KeyValuePair>
						<KeyValuePair>
							<Key>2</Key>
							<Value>
								<![CDATA[I mindre grad|Not so much||Не так вже й багато]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>2</DisplayOrder>
						</KeyValuePair>
						<KeyValuePair>
							<Key>3</Key>
							<Value>
								<![CDATA[Slet ikke|Not at all||Анітрохи]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>3</DisplayOrder>
						</KeyValuePair>
					</KeyValuePairList>
					<Color>e2f4fb</Color>
				</DataItem>
				<DataItem type=""SingleSelect"">
					<Id>372103</Id>
					<Label>13. Hjælp og støtte fra ledelse og kolleger|13. Help and support from management and colleagues||13. Допомога та підтримка з боку керівництва та колег</Label>
					<Description>
						<![CDATA[Mangler I hjælp og støtte fra jeres ledelse og kolleger?<br>|<br>Do you lack help and support from your management and colleagues?||<br>Вам не вистачає допомоги і підтримки з боку вашого керівництва і колег?]]>
					</Description>
					<DisplayOrder>12</DisplayOrder>
					<Mandatory>false</Mandatory>
					<KeyValuePairList>
						<KeyValuePair>
							<Key>1</Key>
							<Value>
								<![CDATA[I høj grad|Very much||Дуже сильно]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>1</DisplayOrder>
						</KeyValuePair>
						<KeyValuePair>
							<Key>2</Key>
							<Value>
								<![CDATA[I mindre grad|Not so much||Не так вже й багато]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>2</DisplayOrder>
						</KeyValuePair>
						<KeyValuePair>
							<Key>3</Key>
							<Value>
								<![CDATA[Slet ikke|Not at all||Анітрохи]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>3</DisplayOrder>
						</KeyValuePair>
					</KeyValuePairList>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""SingleSelect"">
					<Id>372104</Id>
					<Label>14. Mobning|14. Bullying||14. Знущання</Label>
					<Description>
						<![CDATA[Er der nogen på arbejdspladsen, der bliver udsat for mobning?<br>|<br>Is anyone in the workplace being bullied?||<br>Над ким-небудь на робочому місці знущаються?]]>
					</Description>
					<DisplayOrder>13</DisplayOrder>
					<Mandatory>false</Mandatory>
					<KeyValuePairList>
						<KeyValuePair>
							<Key>1</Key>
							<Value>
								<![CDATA[I høj grad|Very much||Дуже сильно]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>1</DisplayOrder>
						</KeyValuePair>
						<KeyValuePair>
							<Key>2</Key>
							<Value>
								<![CDATA[I mindre grad|Not so much||Не так вже й багато]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>2</DisplayOrder>
						</KeyValuePair>
						<KeyValuePair>
							<Key>3</Key>
							<Value>
								<![CDATA[Slet ikke|Not at all||Анітрохи]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>3</DisplayOrder>
						</KeyValuePair>
					</KeyValuePairList>
					<Color>e2f4fb</Color>
				</DataItem>
				<DataItem type=""SingleSelect"">
					<Id>372105</Id>
					<Label>15. Infektionsrisiko|15. Risk of infection||15. Ризик зараження</Label>
					<Description>
						<![CDATA[Er der risiko for infektioner eller luftvejsbelastninger, når I arbejder med dyr?<br>|<br>Is there a risk of infections or respiratory loads when working with animals?||<br>Чи існує ризик інфекцій або респіраторних навантажень при роботі з тваринами?]]>
					</Description>
					<DisplayOrder>14</DisplayOrder>
					<Mandatory>false</Mandatory>
					<KeyValuePairList>
						<KeyValuePair>
							<Key>1</Key>
							<Value>
								<![CDATA[I høj grad|Very much||Дуже сильно]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>1</DisplayOrder>
						</KeyValuePair>
						<KeyValuePair>
							<Key>2</Key>
							<Value>
								<![CDATA[I mindre grad|Not so much||Не так вже й багато]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>2</DisplayOrder>
						</KeyValuePair>
						<KeyValuePair>
							<Key>3</Key>
							<Value>
								<![CDATA[Slet ikke|Not at all||Анітрохи]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>3</DisplayOrder>
						</KeyValuePair>
					</KeyValuePairList>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""SingleSelect"">
					<Id>372106</Id>
					<Label>16. Farlige stoffer og materialer|16. Hazardous substances and materials||16. Небезпечні речовини і матеріали</Label>
					<Description>
						<![CDATA[Arbejder I med faremærkede produkter som fx bekæmpelsesmidler, desinficeringsmidler, rengøringsmidler og&nbsp;flydende ammoniak eller med andre produkter som fx gødning, antibiotika og andre veterinærlægemidler, der&nbsp;kan indeholde farlige stoffer og materialer?<br>|<br>Do you work with hazardous products such as pesticides, disinfectants, cleaning agents and liquid ammonia or with other products such as fertilizers, antibiotics and other veterinary medicines that may contain dangerous substances and materials?||<br>Чи працюєте ви з небезпечними продуктами, такими як пестициди, дезінфікуючі засоби, чистячі засоби і рідкий аміак, або з іншими продуктами, такими як добрива, антибіотики та інші ветеринарні препарати, які можуть містити небезпечні речовини і матеріали?]]>
					</Description>
					<DisplayOrder>15</DisplayOrder>
					<Mandatory>false</Mandatory>
					<KeyValuePairList>
						<KeyValuePair>
							<Key>1</Key>
							<Value>
								<![CDATA[I høj grad|Very much||Дуже сильно]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>1</DisplayOrder>
						</KeyValuePair>
						<KeyValuePair>
							<Key>2</Key>
							<Value>
								<![CDATA[I mindre grad|Not so much||Не так вже й багато]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>2</DisplayOrder>
						</KeyValuePair>
						<KeyValuePair>
							<Key>3</Key>
							<Value>
								<![CDATA[Slet ikke|Not at all||Анітрохи]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>3</DisplayOrder>
						</KeyValuePair>
					</KeyValuePairList>
					<Color>e2f4fb</Color>
				</DataItem>
				<DataItem type=""SingleSelect"">
					<Id>372107</Id>
					<Label>17. Støv, gasser og røg|17. Dust, gases and fumes||17. Пил, гази і пари</Label>
					<Description>
						<![CDATA[Er der risiko for, at I bliver udsat for støv, gas eller røg fra flis, hø, halm, korn, gylle, fisk der rådner, ensilage,&nbsp;udstødning eller svejsning?<br>|<br>Is there a risk that you will be exposed to dust, gas or smoke from wood chips, hay, straw, grain, manure, rotting fish, silage, exhaust or welding?||<br>Чи існує ризик того, що ви піддаєтеся впливу пилу, газу або диму від деревної тріски, сіна, соломи, зерна, гною, гниючої риби, силосу, вихлопних газів або зварювання?]]>
					</Description>
					<DisplayOrder>16</DisplayOrder>
					<Mandatory>false</Mandatory>
					<KeyValuePairList>
						<KeyValuePair>
							<Key>1</Key>
							<Value>
								<![CDATA[I høj grad|Very much||Дуже сильно]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>1</DisplayOrder>
						</KeyValuePair>
						<KeyValuePair>
							<Key>2</Key>
							<Value>
								<![CDATA[I mindre grad|Not so much||Не так вже й багато]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>2</DisplayOrder>
						</KeyValuePair>
						<KeyValuePair>
							<Key>3</Key>
							<Value>
								<![CDATA[Slet ikke|Not at all||Анітрохи]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>3</DisplayOrder>
						</KeyValuePair>
					</KeyValuePairList>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""SingleSelect"">
					<Id>372108</Id>
					<Label>18. Våde eller fugtige hænder|18. Wet or damp hands||18. Промоклість або вологі руки</Label>
					<Description>
						<![CDATA[Arbejder I med våde eller fugtige hænder i mere end 2 timer om dagen?<br>|<br>Do you work with wet or damp hands for more than 2 hours a day?||<br>Чи працюєте ви мокрими або вологими руками більше 2 годин на день?]]>
					</Description>
					<DisplayOrder>17</DisplayOrder>
					<Mandatory>false</Mandatory>
					<KeyValuePairList>
						<KeyValuePair>
							<Key>1</Key>
							<Value>
								<![CDATA[I høj grad|Very much||Дуже сильно]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>1</DisplayOrder>
						</KeyValuePair>
						<KeyValuePair>
							<Key>2</Key>
							<Value>
								<![CDATA[I mindre grad|Not so much||Не так вже й багато]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>2</DisplayOrder>
						</KeyValuePair>
						<KeyValuePair>
							<Key>3</Key>
							<Value>
								<![CDATA[Slet ikke|Not at all||Анітрохи]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>3</DisplayOrder>
						</KeyValuePair>
					</KeyValuePairList>
					<Color>e2f4fb</Color>
				</DataItem>
				<DataItem type=""SingleSelect"">
					<Id>372109</Id>
					<Label>19. Helkropsvibrationer|19. Whole body vibrations||19. Вібрації всього тіла</Label>
					<Description>
						<![CDATA[Kører I med traktorer, høstmateriel, minilæssere og andre maskiner, der udsætter jer for kraftige vibrationer?<br>|<br>Do you drive with tractors, harvesting equipment, mini loaders and other machines that expose you to strong vibrations?||<br>Ви їздите на тракторах, збиральній техніці, міні-навантажувачах та інших машинах, які піддають вас сильним вібраціям?]]>
					</Description>
					<DisplayOrder>18</DisplayOrder>
					<Mandatory>false</Mandatory>
					<KeyValuePairList>
						<KeyValuePair>
							<Key>1</Key>
							<Value>
								<![CDATA[I høj grad|Very much||Дуже сильно]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>1</DisplayOrder>
						</KeyValuePair>
						<KeyValuePair>
							<Key>2</Key>
							<Value>
								<![CDATA[I mindre grad|Not so much||Не так вже й багато]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>2</DisplayOrder>
						</KeyValuePair>
						<KeyValuePair>
							<Key>3</Key>
							<Value>
								<![CDATA[Slet ikke|Not at all||Анітрохи]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>3</DisplayOrder>
						</KeyValuePair>
					</KeyValuePairList>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""SingleSelect"">
					<Id>372110</Id>
					<Label>20. Hånd-armvibrationer|20. Hand-arm vibrations||20. Вібрації рук</Label>
					<Description>
						<![CDATA[Har I snurrende eller følelsesløse fingre, når I har arbejdet med meget vibrerende værktøj som fx motorsave,&nbsp;højtryksrensere og vinkelslibere?<br>|<br>Do you have tingling or numb fingers when you have worked with very vibrating tools such as chainsaws, high-pressure cleaners and angle grinders?||<br>У вас поколює або німіють пальці, коли ви працюєте з дуже вібруючими інструментами, такими як бензопили, очищувачі високого тиску і кутові шліфувальні машини?]]>
					</Description>
					<DisplayOrder>19</DisplayOrder>
					<Mandatory>false</Mandatory>
					<KeyValuePairList>
						<KeyValuePair>
							<Key>1</Key>
							<Value>
								<![CDATA[I høj grad|Very much||Дуже сильно]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>1</DisplayOrder>
						</KeyValuePair>
						<KeyValuePair>
							<Key>2</Key>
							<Value>
								<![CDATA[I mindre grad|Not so much||Не так вже й багато]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>2</DisplayOrder>
						</KeyValuePair>
						<KeyValuePair>
							<Key>3</Key>
							<Value>
								<![CDATA[Slet ikke|Not at all||Анітрохи]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>3</DisplayOrder>
						</KeyValuePair>
					</KeyValuePairList>
					<Color>e2f4fb</Color>
				</DataItem>
				<DataItem type=""SingleSelect"">
					<Id>372112</Id>
					<Label>21. Alt i alt oplever jeg, at arbejdsforholdende er gode på min arbejdsplads|21. All in all, I find that working conditions are good in my workplace||21. В цілому, я вважаю, що умови праці на моєму робочому місці хороші</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>20</DisplayOrder>
					<Mandatory>false</Mandatory>
					<KeyValuePairList>
						<KeyValuePair>
							<Key>1</Key>
							<Value>
								<![CDATA[I høj grad|Very much||Дуже сильно]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>1</DisplayOrder>
						</KeyValuePair>
						<KeyValuePair>
							<Key>2</Key>
							<Value>
								<![CDATA[I mindre grad|Not so much||Не так вже й багато]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>2</DisplayOrder>
						</KeyValuePair>
						<KeyValuePair>
							<Key>3</Key>
							<Value>
								<![CDATA[Slet ikke|Not at all||Анітрохи]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>3</DisplayOrder>
						</KeyValuePair>
					</KeyValuePairList>
					<Color>fff6df</Color>
				</DataItem>
				<DataItem type=""Text"">
					<Id>372113</Id>
					<Label>Kommentarer til arbejdsforholdende|Comments on working conditions||Коментарі щодо умов праці</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>21</DisplayOrder>
					<Multi>0</Multi>
					<GeolocationEnabled>false</GeolocationEnabled>
					<Split>false</Split>
					<Value/>
					<ReadOnly>false</ReadOnly>
					<Mandatory>false</Mandatory>
					<Color>fff6df</Color>
				</DataItem>
				<DataItem type=""SaveButton"">
					<Id>372111</Id>
					<Label>Gem registrering|Save registration||Зберегти реєстрацію</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>22</DisplayOrder>
					<Value>GEM|SAVE||ЗБЕРЕГТИ</Value>
					<Color>f0f8db</Color>
				</DataItem>
			</DataItemList>
		</Element>
	</ElementList>
</Main>",
@"<?xml version=""1.0"" encoding=""UTF-8""?>
<Main>
	<Id>142401</Id>
	<Repeated>0</Repeated>
	<Label>14. Maskiner|14. Machines||14. Машини</Label>
	<StartDate>2021-05-20</StartDate>
	<EndDate>2031-05-20</EndDate>
	<Language>da</Language>
	<MultiApproval>false</MultiApproval>
	<FastNavigation>false</FastNavigation>
	<Review>false</Review>
	<Summary>false</Summary>
	<DisplayOrder>0</DisplayOrder>
	<ElementList>
		<Element type=""DataElement"">
			<Id>142401</Id>
			<Label>14. Maskiner|14. Machines||14. Машини</Label>
			<Description>
				<![CDATA[<br>]]>
			</Description>
			<DisplayOrder>0</DisplayOrder>
			<ReviewEnabled>false</ReviewEnabled>
			<ManualSync>false</ManualSync>
			<ExtraFieldsEnabled>false</ExtraFieldsEnabled>
			<DoneButtonDisabled>true</DoneButtonDisabled>
			<ApprovalEnabled>false</ApprovalEnabled>
			<DataItemGroupList>
				<DataItemGroup type=""FieldGroup"">
					<Id>373705</Id>
					<Label>LÆS MERE|READ MORE||ДОКЛАДНО</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>0</DisplayOrder>
					<Value>Closed</Value>
					<Color>fff6df</Color>
					<DataItemList>
						<DataItem type=""None"">
							<Id>373706</Id>
							<Label>INFO|INFO||ІНФОРМАЦІЯ</Label>
							<Description>
								<![CDATA[Det er vigtigt, at maskinparken løbende vedligeholdes for at sikre optimal drift og for at undgå uheld.<br>|<br>It is important that the machinery is continuously maintained to ensure optimal operation and to avoid accidents.||<br>Важливо, щоб обладнання постійно обслуговувалося, щоб забезпечити оптимальну роботу і уникнути нещасних випадків.]]>
							</Description>
							<DisplayOrder>0</DisplayOrder>
							<Color>fff6df</Color>
						</DataItem>
					</DataItemList>
				</DataItemGroup>
			</DataItemGroupList>
			<DataItemList>
				<DataItem type=""Date"">
					<Id>373704</Id>
					<Label>Indtast dato for sidste service|Enter date of last service||Введіть дату останнього обслуговування</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>1</DisplayOrder>
					<MinValue>2021-09-08</MinValue>
					<MaxValue>2031-09-08</MaxValue>
					<Value/>
					<Mandatory>false</Mandatory>
					<ReadOnly>false</ReadOnly>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>373707</Id>
					<Label>Hydrauliksystem og slanger kontrolleret|Hydraulic system and hoses checked||Гідравлічна система і шланги перевірені</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>2</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>373708</Id>
					<Label>Lys, blinklys og bremser kontrolleret|Lights, turn signals and brakes checked||Фари, поворотники і гальма перевірені</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>3</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>373709</Id>
					<Label>Ingen utætheder|No leaks||Ніяких витоків</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>4</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>373710</Id>
					<Label>Sliddele kontrolleret|Wear parts checked||Перевірка зношуваних деталей</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>5</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>373711</Id>
					<Label>Olie kontrolleret|Oil checked||Перевірено масло</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>6</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Picture"">
					<Id>373702</Id>
					<Label>Billede|Picture||Зображення</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>7</DisplayOrder>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Comment"">
					<Id>373701</Id>
					<Label>Kommentar|Comment||Коментар</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>8</DisplayOrder>
					<Multi>1</Multi>
					<GeolocationEnabled>false</GeolocationEnabled>
					<Split>false</Split>
					<Value/>
					<ReadOnly>false</ReadOnly>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""SaveButton"">
					<Id>373703</Id>
					<Label>Gem registrering|Save registration||Зберегти реєстрацію</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>9</DisplayOrder>
					<Value>GEM|SAVE||ЗБЕРЕГТИ</Value>
					<Color>f0f8db</Color>
				</DataItem>
			</DataItemList>
		</Element>
	</ElementList>
</Main>",
@"<?xml version=""1.0"" encoding=""UTF-8""?>
<Main>
	<Id>142593</Id>
	<Repeated>0</Repeated>
	<Label>15. Elværktøj|15. Power tools||15. Електроінструмент</Label>
	<StartDate>2021-09-08</StartDate>
	<EndDate>2031-09-08</EndDate>
	<Language>da</Language>
	<MultiApproval>false</MultiApproval>
	<FastNavigation>false</FastNavigation>
	<Review>false</Review>
	<Summary>false</Summary>
	<DisplayOrder>0</DisplayOrder>
	<ElementList>
		<Element type=""DataElement"">
			<Id>142593</Id>
			<Label>15. Elværktøj|15. Power tools||15. Електроінструмент</Label>
			<Description>
				<![CDATA[]]>
			</Description>
			<DisplayOrder>0</DisplayOrder>
			<ReviewEnabled>false</ReviewEnabled>
			<ManualSync>false</ManualSync>
			<ExtraFieldsEnabled>false</ExtraFieldsEnabled>
			<DoneButtonDisabled>true</DoneButtonDisabled>
			<ApprovalEnabled>false</ApprovalEnabled>
			<DataItemGroupList>
				<DataItemGroup type=""FieldGroup"">
					<Id>375208</Id>
					<Label>LÆS MERE|READ MORE||ДОКЛАДНО</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>0</DisplayOrder>
					<Value>Closed</Value>
					<Color>fff6df</Color>
					<DataItemList>
						<DataItem type=""None"">
							<Id>375209</Id>
							<Label>INFO|INFO||ІНФОРМАЦІЯ</Label>
							<Description>
								<![CDATA[Tilpas evt. tjeklisten i <b><i>Microting eForm Editor</i></b>, med baggrund i anvisninger for eftersyn af det aktuelle redskab og i henhold til de informationer leverandøren har anført i håndværktøjets brugsanvisning.<br>|<br>Adjust - if necessary - the checklist in the <b><i>Microting eForm Editor</i></b>, based on instructions for inspecting the current tool and according to the information provided by the supplier in the manual of the hand tool.||<br>Скорегуйте - при необхідності - еформу в <b><i>Microting eForm Editor.</i></b> На основі інструкцій з перевірки поточного інструменту і відповідно до інформації, наданої постачальником в керівництві по ручному інструменту.]]>
							</Description>
							<DisplayOrder>0</DisplayOrder>
							<Color>fff6df</Color>
						</DataItem>
					</DataItemList>
				</DataItemGroup>
			</DataItemGroupList>
			<DataItemList>
				<DataItem type=""CheckBox"">
					<Id>375210</Id>
					<Label>Ledninger OK|Wires OK||Дроти в порядку</Label>
					<Description>
						<![CDATA[Tjek for skader, revner eller huller på ledninger|Check for damage, cracks or holes in wires||Перевірте, чи немає пошкоджень, тріщин або отворів в проводах]]>
					</Description>
					<DisplayOrder>1</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>375211</Id>
					<Label>Stik OK|Plug OK||Вилка в порядку</Label>
					<Description>
						<![CDATA[Tjek for skader, revner mm.|Check for damage, cracks etc.||Перевірте, чи немає пошкоджень, тріщин і т. д.]]>
					</Description>
					<DisplayOrder>2</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>375207</Id>
					<Label>Værktøjshus og håndtag OK|Tool house and handle OK||Корпус інструменту і рукоятка в порядку</Label>
					<Description>
						<![CDATA[Tjek for skader, revner, brud mv.|Check for damage, cracks, fractures, etc.||Перевірте, чи немає пошкоджень, тріщин, переломів і т. д.]]>
					</Description>
					<DisplayOrder>3</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>375212</Id>
					<Label>Maskine i god stand|Machine in good condition||Машина в хорошому стані</Label>
					<Description>
						<![CDATA[Tjek om el-materiellet er rent, fri for fedt og har frie ventilationsåbninger| Check that the electrical equipment is clean, free of grease and has free ventilation openings||Переконайтеся, що електрообладнання чисте, без мастила і має вільні вентиляційні отвори]]>
					</Description>
					<DisplayOrder>4</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>375213</Id>
					<Label>Ingen tegn på overbelastning|No signs of congestion||Ніяких ознак заторів</Label>
					<Description>
						<![CDATA[Tjek for synlige spor mv.|Check for visible traces etc.||Перевірте наявність видимих слідів і т. д.]]>
					</Description>
					<DisplayOrder>5</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>375214</Id>
					<Label>Betjeningsknapper OK|Control buttons OK||Кнопки управління в порядку</Label>
					<Description>
						<![CDATA[Tjek at START/STOP knapper og andre kontakter virker efter hensigten|Check that START/STOP buttons and other switches work as intended||Переконайтеся, що кнопки запуску/зупинки та інші перемикачі працюють належним чином]]>
					</Description>
					<DisplayOrder>6</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""SingleSelect"">
					<Id>375215</Id>
					<Label>Kan elværktøjet godkendes?|Can the power tool be approved?||Чи можна схвалити електроінструмент?</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>7</DisplayOrder>
					<Mandatory>false</Mandatory>
					<KeyValuePairList>
						<KeyValuePair>
							<Key>1</Key>
							<Value>
								<![CDATA[Ja|Yes||Так]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>1</DisplayOrder>
						</KeyValuePair>
						<KeyValuePair>
							<Key>2</Key>
							<Value>
								<![CDATA[Nej, skal repareres|No, needs to be repaired||Ні, потребує ремонту]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>2</DisplayOrder>
						</KeyValuePair>
						<KeyValuePair>
							<Key>3</Key>
							<Value>
								<![CDATA[Nej, skal kasseres|No, must be discarded||Ні, має бути відкинуто]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>3</DisplayOrder>
						</KeyValuePair>
					</KeyValuePairList>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Picture"">
					<Id>375205</Id>
					<Label>Billede|Picture||Зображення</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>8</DisplayOrder>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Comment"">
					<Id>375204</Id>
					<Label>Kommentar|Comment||Коментар</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>9</DisplayOrder>
					<Multi>1</Multi>
					<GeolocationEnabled>false</GeolocationEnabled>
					<Split>false</Split>
					<Value/>
					<ReadOnly>false</ReadOnly>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""SaveButton"">
					<Id>375206</Id>
					<Label>Gem registrering|Save registration||Зберегти реєстрацію</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>10</DisplayOrder>
					<Value>GEM|SAVE||ЗБЕРЕГТИ</Value>
					<Color>f0f8db</Color>
				</DataItem>
			</DataItemList>
		</Element>
	</ElementList>
</Main>",
@"<?xml version=""1.0"" encoding=""UTF-8""?>
<Main>
	<Id>142594</Id>
	<Repeated>0</Repeated>
	<Label>16. Stiger|16. Ladders||16. Сходи</Label>
	<StartDate>2021-09-08</StartDate>
	<EndDate>2031-09-08</EndDate>
	<Language>da</Language>
	<MultiApproval>false</MultiApproval>
	<FastNavigation>false</FastNavigation>
	<Review>false</Review>
	<Summary>false</Summary>
	<DisplayOrder>0</DisplayOrder>
	<ElementList>
		<Element type=""DataElement"">
			<Id>142594</Id>
			<Label>16. Stiger|16. Ladders||16. Сходи</Label>
			<Description>
				<![CDATA[]]>
			</Description>
			<DisplayOrder>0</DisplayOrder>
			<ReviewEnabled>false</ReviewEnabled>
			<ManualSync>false</ManualSync>
			<ExtraFieldsEnabled>false</ExtraFieldsEnabled>
			<DoneButtonDisabled>true</DoneButtonDisabled>
			<ApprovalEnabled>false</ApprovalEnabled>
			<DataItemGroupList>
				<DataItemGroup type=""FieldGroup"">
					<Id>375220</Id>
					<Label>LÆS MERE|READ MORE||ДОКЛАДНО</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>0</DisplayOrder>
					<Value>Closed</Value>
					<Color>fff6df</Color>
					<DataItemList>
						<DataItem type=""None"">
							<Id>375221</Id>
							<Label>INFO|INFO||ІНФОРМАЦІЯ</Label>
							<Description>
								<![CDATA[Tilpas evt. tjeklisten i <b><i>Microting eForm Editor</i></b>, med baggrund i anvisninger for eftersyn af den aktuelle stige og i henhold til de informationer leverandøren har anført i stigens brugsanvisning.<br>|<br>Adjust - if necessary - the checklist in the <b><i>Microting eForm Editor</i></b>, based on instructions for inspecting the current ladder and according to the information provided by the supplier in the manual of the ladder.||<br>Скорегуйте - при необхідності - еформу в <b><i>Microting eForm Editor.</i></b> На основі інструкцій з перевірки поточної сходи і відповідно до інформації, наданої постачальником в керівництві по сходах.]]>
							</Description>
							<DisplayOrder>0</DisplayOrder>
							<Color>fff6df</Color>
						</DataItem>
					</DataItemList>
				</DataItemGroup>
			</DataItemGroupList>
			<DataItemList>
				<DataItem type=""CheckBox"">
					<Id>375228</Id>
					<Label>Stige udført i henhold til Standard EN 131|Ladder made in accordance with Standard EN 131||Сходи виготовлені відповідно до стандарту EN 131</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>1</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e2f4fb</Color>
				</DataItem>
				<DataItem type=""Comment"">
					<Id>375229</Id>
					<Label>Anden standard|Other standard||Інший стандарт</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>2</DisplayOrder>
					<Multi>1</Multi>
					<GeolocationEnabled>false</GeolocationEnabled>
					<Split>false</Split>
					<Value/>
					<ReadOnly>false</ReadOnly>
					<Mandatory>false</Mandatory>
					<Color>e2f4fb</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>375222</Id>
					<Label>Stigebeslag OK|Ladder fittings OK||Сходовий кронштейн в порядку</Label>
					<Description>
						<![CDATA[Ikke skæve, løse, mv.|Not crooked, loose, etc.||Не криво, не вільно і т. д.]]>
					</Description>
					<DisplayOrder>3</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>375223</Id>
					<Label>Kæder OK|Chains OK||Ланцюги в порядку</Label>
					<Description>
						<![CDATA[Ingen løs befæstning, ikke itu, mv.|No loose fastening, not broken, etc.||Немає ослабленого кріплення, не зламано і т. д.]]>
					</Description>
					<DisplayOrder>4</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>375219</Id>
					<Label>Vanger OK|Stringer OK||Стрінгер в порядку</Label>
					<Description>
						<![CDATA[Ikke skæve, flækkede, mv.|Not crooked, cracked, etc.||Не криві, не тріснуті і т. д.]]>
					</Description>
					<DisplayOrder>5</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>375224</Id>
					<Label>Trin OK|Steps OK||Сходинки в порядку</Label>
					<Description>
						<![CDATA[Ikke skæve, løse, mv.| Not crooked, loose, etc.||Не криво, не вільно і т. д.]]>
					</Description>
					<DisplayOrder>6</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>375225</Id>
					<Label>Stigedupper OK|Ladder pads OK||Сходові колодки в порядку</Label>
					<Description>
						<![CDATA[Ikke skæve, revnede, mv.|Not crooked, cracked, etc.||Не криві, не тріснуті і т. д.]]>
					</Description>
					<DisplayOrder>7</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>375226</Id>
					<Label>Efterbehandling OK|Subsequent treatment OK||Оздоблення в порядку</Label>
					<Description>
						<![CDATA[F.eks. ingen skader på lakering, mv.| Eg. no damage to paintwork, etc.||Напр. ніяких пошкоджень лакофарбового покриття і т. д.]]>
					</Description>
					<DisplayOrder>8</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>375230</Id>
					<Label>Ingen tegn på misbrug|No signs of abuse||Ніяких ознак жорстокого поводження</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>9</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>375231</Id>
					<Label>Ikke vakkelvorn ved brug|Do not wobble when used||Не розгойдували при використанні</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>10</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""SingleSelect"">
					<Id>375227</Id>
					<Label>Kan stigen godkendes?|Can the ladder be approved?||Чи можна затвердити сходи?</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>11</DisplayOrder>
					<Mandatory>false</Mandatory>
					<KeyValuePairList>
						<KeyValuePair>
							<Key>1</Key>
							<Value>
								<![CDATA[Ja|Yes||Так]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>1</DisplayOrder>
						</KeyValuePair>
						<KeyValuePair>
							<Key>2</Key>
							<Value>
								<![CDATA[Nej, skal repareres|No, needs to be repaired||Ні, потребує ремонту]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>2</DisplayOrder>
						</KeyValuePair>
						<KeyValuePair>
							<Key>3</Key>
							<Value>
								<![CDATA[Nej, skal kasseres|No, must be discarded||Ні, має бути відкинуто]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>3</DisplayOrder>
						</KeyValuePair>
					</KeyValuePairList>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Picture"">
					<Id>375217</Id>
					<Label>Billede|Picture||Зображення</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>12</DisplayOrder>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Comment"">
					<Id>375216</Id>
					<Label>Kommentar|Comment||Коментар</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>13</DisplayOrder>
					<Multi>1</Multi>
					<GeolocationEnabled>false</GeolocationEnabled>
					<Split>false</Split>
					<Value/>
					<ReadOnly>false</ReadOnly>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""SaveButton"">
					<Id>375218</Id>
					<Label>Gem registrering|Save registration||Зберегти реєстрацію</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>14</DisplayOrder>
					<Value>GEM|SAVE||ЗБЕРЕГТИ</Value>
					<Color>f0f8db</Color>
				</DataItem>
			</DataItemList>
		</Element>
	</ElementList>
</Main>",
@"<?xml version=""1.0"" encoding=""UTF-8""?>
<Main>
	<Id>142595</Id>
	<Repeated>0</Repeated>
	<Label>17. Håndildslukkere|17. Fire extinguishers||17. Вогнегасник</Label>
	<StartDate>2021-09-08</StartDate>
	<EndDate>2031-09-08</EndDate>
	<Language>da</Language>
	<MultiApproval>false</MultiApproval>
	<FastNavigation>false</FastNavigation>
	<Review>false</Review>
	<Summary>false</Summary>
	<DisplayOrder>0</DisplayOrder>
	<ElementList>
		<Element type=""DataElement"">
			<Id>142595</Id>
			<Label>17. Håndildslukkere|17. Fire extinguishers||17. Вогнегасник</Label>
			<Description>
				<![CDATA[]]>
			</Description>
			<DisplayOrder>0</DisplayOrder>
			<ReviewEnabled>false</ReviewEnabled>
			<ManualSync>false</ManualSync>
			<ExtraFieldsEnabled>false</ExtraFieldsEnabled>
			<DoneButtonDisabled>true</DoneButtonDisabled>
			<ApprovalEnabled>false</ApprovalEnabled>
			<DataItemGroupList>
				<DataItemGroup type=""FieldGroup"">
					<Id>375236</Id>
					<Label>LÆS MERE|READ MORE||ДОКЛАДНО</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>0</DisplayOrder>
					<Value>Closed</Value>
					<Color>fff6df</Color>
					<DataItemList>
						<DataItem type=""None"">
							<Id>375237</Id>
							<Label>INFO|INFO||ІНФОРМАЦІЯ</Label>
							<Description>
								<![CDATA[Tilpas evt. tjeklisten i <b><i>Microting eForm Editor</i></b>, med baggrund i anvisninger for eftersyn af den aktuelle ildslukker og i henhold til de informationer leverandøren har anført i ildslukkerens brugsanvisning.<br>|<br>Adjust - if necessary - the checklist in the <b><i>Microting eForm Editor</i></b>, based on instructions for inspecting the current fire extinguisher and according to the information provided by the supplier in the manual of the fire extinguisher.||<br>Скорегуйте - при необхідності - еформу в<b><i>Microting eForm Editor.</i></b>На основі інструкцій з перевірки поточного вогнегасника і відповідно до інформації, наданої постачальником в керівництві з вогнегасника.]]>
							</Description>
							<DisplayOrder>0</DisplayOrder>
							<Color>fff6df</Color>
						</DataItem>
					</DataItemList>
				</DataItemGroup>
			</DataItemGroupList>
			<DataItemList>
				<DataItem type=""CheckBox"">
					<Id>375244</Id>
					<Label>Ildslukker udført i henhold til DS/EN 3|Fire extinguisher made in accordance with DS/EN 3||Вогнегасник, виготовлений відповідно до DS/EN 3</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>1</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e2f4fb</Color>
				</DataItem>
				<DataItem type=""Comment"">
					<Id>375245</Id>
					<Label>Anden standard|Other standard||Інший стандарт</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>2</DisplayOrder>
					<Multi>1</Multi>
					<GeolocationEnabled>false</GeolocationEnabled>
					<Split>false</Split>
					<Value/>
					<ReadOnly>false</ReadOnly>
					<Mandatory>false</Mandatory>
					<Color>e2f4fb</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>375238</Id>
					<Label>Ophængning OK|Suspension OK||Підвіска в порядку</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>3</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>375239</Id>
					<Label>Tilgængelighed OK|Availability OK||Доступність в порядку</Label>
					<Description>
						<![CDATA[Tjek, at der ikke er placeret gods mv. foran håndslukkeren| Check that no goods, etc. have been placed in front of the fire extinguisher||Переконайтеся, що перед вогнегасником не було розміщено ніяких товарів і т. д.]]>
					</Description>
					<DisplayOrder>4</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>375235</Id>
					<Label>Sikkerhedsskiltning OK|Safety signs OK||Знаки безпеки в порядку</Label>
					<Description>
						<![CDATA[Tjek, at skilte er opsat på væg eller lignende|Check that signs are mounted on the wall or similar||Переконайтеся, що таблички встановлені на стіні або аналогічні]]>
					</Description>
					<DisplayOrder>5</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>375240</Id>
					<Label>Funktionsklar og intakt|Functional and intact||Функціональний і неушкоджений</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>6</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>375241</Id>
					<Label>Brugsanvisning på slukker OK|Instructions for use on extinguisher OK||Інструкція по застосуванню вогнегасника в порядку</Label>
					<Description>
						<![CDATA[Tjek, at informationer vedrørende brug af ildslukker kan læses|Check that information regarding the use of the extinguisher can be read||Переконайтеся, що інформація про використання вогнегасника може бути прочитана]]>
					</Description>
					<DisplayOrder>7</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>375242</Id>
					<Label>Trykmåler OK|Pressure gauge OK||Манометр в порядку</Label>
					<Description>
						<![CDATA[Tjek, at der vises korrekt driftstryk|Check that the correct operating pressure is displayed||Переконайтеся, що відображається правильний робочий тиск]]>
					</Description>
					<DisplayOrder>8</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>375246</Id>
					<Label>Ingen synlige beskadigelser|No visible damages||Ніяких видимих пошкоджень</Label>
					<Description>
						<![CDATA[Tjek beholder og håndtag|Check container and handle||Перевірте контейнер і ручку]]>
					</Description>
					<DisplayOrder>9</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>375247</Id>
					<Label>Kontrolvejning af CO2-slukker OK|Control weighing of CO2 extinguisher||Контрольне зважування вогнегасника CO2</Label>
					<Description>
						<![CDATA[Se beholder for vægtangivelse|See container for weight declaration||Див. розділ контейнер для декларації ваги]]>
					</Description>
					<DisplayOrder>10</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>375248</Id>
					<Label>Plomberingen OK|The seal is OK||Герметизація в порядку</Label>
					<Description>
						<![CDATA[Tjek om plomberingen er intakt|Check if seal is intact||Перевірте, чи ціла пломба]]>
					</Description>
					<DisplayOrder>11</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""SingleSelect"">
					<Id>375243</Id>
					<Label>Kan ildslukkeren godkendes?|Can the fire extinguisher be approved?||Чи може бути схвалений вогнегасник?</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>12</DisplayOrder>
					<Mandatory>false</Mandatory>
					<KeyValuePairList>
						<KeyValuePair>
							<Key>1</Key>
							<Value>
								<![CDATA[Ja|Yes||Так]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>1</DisplayOrder>
						</KeyValuePair>
						<KeyValuePair>
							<Key>2</Key>
							<Value>
								<![CDATA[Nej, skal repareres|No, needs to be repaired||Ні, потребує ремонту]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>2</DisplayOrder>
						</KeyValuePair>
						<KeyValuePair>
							<Key>3</Key>
							<Value>
								<![CDATA[Nej, skal kasseres|No, must be discarded||Ні, має бути відкинуто]]>
							</Value>
							<Selected>false</Selected>
							<DisplayOrder>3</DisplayOrder>
						</KeyValuePair>
					</KeyValuePairList>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Picture"">
					<Id>375233</Id>
					<Label>Billede|Picture||Зображення</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>13</DisplayOrder>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Comment"">
					<Id>375232</Id>
					<Label>Kommentar|Comment||Коментар</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>14</DisplayOrder>
					<Multi>1</Multi>
					<GeolocationEnabled>false</GeolocationEnabled>
					<Split>false</Split>
					<Value/>
					<ReadOnly>false</ReadOnly>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""SaveButton"">
					<Id>375234</Id>
					<Label>Gem registrering|Save registration||Зберегти реєстрацію</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>15</DisplayOrder>
					<Value>GEM|SAVE||ЗБЕРЕГТИ</Value>
					<Color>f0f8db</Color>
				</DataItem>
			</DataItemList>
		</Element>
	</ElementList>
</Main>",
@"<?xml version=""1.0"" encoding=""UTF-8""?>
<Main>
	<Id>142348</Id>
	<Repeated>0</Repeated>
	<Label>18. Alarm|18. Alarm||18. Сигналізація</Label>
	<StartDate>2021-03-24</StartDate>
	<EndDate>2031-03-24</EndDate>
	<Language>da</Language>
	<MultiApproval>false</MultiApproval>
	<FastNavigation>false</FastNavigation>
	<Review>false</Review>
	<Summary>false</Summary>
	<DisplayOrder>0</DisplayOrder>
	<ElementList>
		<Element type=""DataElement"">
			<Id>142348</Id>
			<Label>18. Alarm|18. Alarm||18. Сигналізація</Label>
			<Description>
				<![CDATA[Tjek af alarm<br>|<br>Alarm check||<br>Перевірка сигналізації]]>
			</Description>
			<DisplayOrder>0</DisplayOrder>
			<ReviewEnabled>false</ReviewEnabled>
			<ManualSync>false</ManualSync>
			<ExtraFieldsEnabled>false</ExtraFieldsEnabled>
			<DoneButtonDisabled>true</DoneButtonDisabled>
			<ApprovalEnabled>false</ApprovalEnabled>
			<DataItemGroupList>
				<DataItemGroup type=""FieldGroup"">
					<Id>373209</Id>
					<Label>LÆS MERE|READ MORE||ДОКЛАДНО</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>0</DisplayOrder>
					<Value>Closed</Value>
					<Color>fff6df</Color>
					<DataItemList>
						<DataItem type=""None"">
							<Id>373210</Id>
							<Label>INFO|INFO||ІНФОРМАЦІЯ</Label>
							<Description>
								<![CDATA[Tjek om der er forbindelse til netværk og test, at alarmen virker<br>|<br>Check if there is a connection to the network and test that the alarm works||<br>Перевірте, чи є підключення до мережі, і перевірте, чи працює сигналізація]]>
							</Description>
							<DisplayOrder>0</DisplayOrder>
							<Color>fff6df</Color>
						</DataItem>
					</DataItemList>
				</DataItemGroup>
			</DataItemGroupList>
			<DataItemList>
				<DataItem type=""CheckBox"">
					<Id>373211</Id>
					<Label>Forbindelse til netværk OK|Network connection OK||Мережеве підключення в порядку</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>1</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>373212</Id>
					<Label>Test af alarm OK|Alarm test OK||Перевірка сигналізації в порядку</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>2</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Picture"">
					<Id>373207</Id>
					<Label>Billede|Picture||Зображення</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>3</DisplayOrder>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Comment"">
					<Id>373206</Id>
					<Label>Kommentar|Comment||Коментар</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>4</DisplayOrder>
					<Multi>1</Multi>
					<GeolocationEnabled>false</GeolocationEnabled>
					<Split>false</Split>
					<Value/>
					<ReadOnly>false</ReadOnly>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""SaveButton"">
					<Id>373208</Id>
					<Label>Gem registrering|Save registration||Зберегти реєстрацію</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>5</DisplayOrder>
					<Value>GEM|SAVE||ЗБЕРЕГТИ</Value>
					<Color>f0f8db</Color>
				</DataItem>
			</DataItemList>
		</Element>
	</ElementList>
</Main>",
@"<?xml version=""1.0"" encoding=""UTF-8""?>
<Main>
	<Id>142425</Id>
	<Repeated>0</Repeated>
	<Label>19. Ventilation|19. Ventilation||19. Вентиляція</Label>
	<StartDate>2021-05-27</StartDate>
	<EndDate>2031-05-27</EndDate>
	<Language>da</Language>
	<MultiApproval>false</MultiApproval>
	<FastNavigation>false</FastNavigation>
	<Review>false</Review>
	<Summary>false</Summary>
	<DisplayOrder>0</DisplayOrder>
	<ElementList>
		<Element type=""DataElement"">
			<Id>142425</Id>
			<Label>19. Ventilation|19. Ventilation||19. Вентиляція</Label>
			<Description>
				<![CDATA[Tjek ventilation<br>|<br>Check ventilation||<br>Перевірте вентиляцію]]>
			</Description>
			<DisplayOrder>0</DisplayOrder>
			<ReviewEnabled>false</ReviewEnabled>
			<ManualSync>false</ManualSync>
			<ExtraFieldsEnabled>false</ExtraFieldsEnabled>
			<DoneButtonDisabled>true</DoneButtonDisabled>
			<ApprovalEnabled>false</ApprovalEnabled>
			<DataItemGroupList>
				<DataItemGroup type=""FieldGroup"">
					<Id>373948</Id>
					<Label>LÆS MERE|READ MORE||ДОКЛАДНО</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>0</DisplayOrder>
					<Value>Closed</Value>
					<Color>fff6df</Color>
					<DataItemList>
						<DataItem type=""None"">
							<Id>373949</Id>
							<Label>INFO|INFO||ІНФОРМАЦІЯ</Label>
							<Description>
								<![CDATA[Et velfungerende ventilationsanlæg medvirker til at minimere sygdomme og øge dyrevelfærden.<br>|<br>A well-functioning ventilation system helps to minimize diseases and increase animal welfare.||<br>Добре функціонуюча система вентиляції допомагає звести до мінімуму захворювання і підвищити добробут тварин.]]>
							</Description>
							<DisplayOrder>0</DisplayOrder>
							<Color>fff6df</Color>
						</DataItem>
					</DataItemList>
				</DataItemGroup>
			</DataItemGroupList>
			<DataItemList>
				<DataItem type=""CheckBox"">
					<Id>373950</Id>
					<Label>Nødopluk OK|Emergency opening OK||Аварійне відкриття в порядку</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>1</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Picture"">
					<Id>373946</Id>
					<Label>Billede|Picture||Зображення</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>3</DisplayOrder>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Comment"">
					<Id>373945</Id>
					<Label>Kommentar|Comment||Коментар</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>4</DisplayOrder>
					<Multi>1</Multi>
					<GeolocationEnabled>false</GeolocationEnabled>
					<Split>false</Split>
					<Value/>
					<ReadOnly>false</ReadOnly>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""SaveButton"">
					<Id>373947</Id>
					<Label>Gem registrering|Save registration||Зберегти реєстрацію</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>5</DisplayOrder>
					<Value>GEM|SAVE||ЗБЕРЕГТИ</Value>
					<Color>f0f8db</Color>
				</DataItem>
			</DataItemList>
		</Element>
	</ElementList>
</Main>",
@"<?xml version=""1.0"" encoding=""UTF-8""?>
<Main>
	<Id>142352</Id>
	<Repeated>0</Repeated>
	<Label>20. Arbejdsopgave udført|20. Task completed||20. Завдання виконано</Label>
	<StartDate>2021-04-05</StartDate>
	<EndDate>2031-04-05</EndDate>
	<Language>da</Language>
	<MultiApproval>false</MultiApproval>
	<FastNavigation>false</FastNavigation>
	<Review>false</Review>
	<Summary>false</Summary>
	<DisplayOrder>0</DisplayOrder>
	<ElementList>
		<Element type=""DataElement"">
			<Id>142352</Id>
			<Label>20. Arbejdsopgave udført|20. Task completed||20. Завдання виконано</Label>
			<Description>
				<![CDATA[]]>
			</Description>
			<DisplayOrder>0</DisplayOrder>
			<ReviewEnabled>false</ReviewEnabled>
			<ManualSync>false</ManualSync>
			<ExtraFieldsEnabled>false</ExtraFieldsEnabled>
			<DoneButtonDisabled>true</DoneButtonDisabled>
			<ApprovalEnabled>false</ApprovalEnabled>
			<DataItemGroupList>
				<DataItemGroup type=""FieldGroup"">
					<Id>373242</Id>
					<Label>LÆS MERE|READ MORE||ДОКЛАДНО</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>0</DisplayOrder>
					<Value>Closed</Value>
					<Color>fff6df</Color>
					<DataItemList>
						<DataItem type=""None"">
							<Id>373243</Id>
							<Label>INFO|INFO||ІНФОРМАЦІЯ</Label>
							<Description>
								<![CDATA[Når du har udført opgaven, skal du sætte kryds i <b>Opgave udført</b> og derefter trykke på <b>GEM</b>. Du kan også tage billeder og skrive en kommentar til opgaven, før du gemmer.<br>|<br>When you have completed the task, check<b> Task completed</b> and then press <b>SAVE</b>. You can also take pictures and write a comment on the task before saving.||<br>Коли ви завершите завдання, позначте<b> завдання виконано</b>, а потім натисніть<b>зберегти < /b>. Ви також можете зробити знімки і написати коментар до завдання перед збереженням.]]>
							</Description>
							<DisplayOrder>0</DisplayOrder>
							<Color>fff6df</Color>
						</DataItem>
					</DataItemList>
				</DataItemGroup>
			</DataItemGroupList>
			<DataItemList>
				<DataItem type=""CheckBox"">
					<Id>373244</Id>
					<Label>Opgave udført|Task completed||Завдання виконано</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>11</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Picture"">
					<Id>373240</Id>
					<Label>Billede|Picture||Зображення</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>12</DisplayOrder>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Comment"">
					<Id>373239</Id>
					<Label>Kommentar|Comment||Коментар</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>13</DisplayOrder>
					<Multi>1</Multi>
					<GeolocationEnabled>false</GeolocationEnabled>
					<Split>false</Split>
					<Value/>
					<ReadOnly>false</ReadOnly>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""SaveButton"">
					<Id>373241</Id>
					<Label>Gem registrering|Save registration||Зберегти реєстрацію</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>14</DisplayOrder>
					<Value>GEM|SAVE||ЗБЕРЕГТИ</Value>
					<Color>f0f8db</Color>
				</DataItem>
			</DataItemList>
		</Element>
	</ElementList>
</Main>",
@"<?xml version=""1.0"" encoding=""UTF-8""?>
<Main>
	<Id>142381</Id>
	<Repeated>0</Repeated>
	<Label>21. DANISH Produktstandard v_1_01|21. DANISH Product standard v_1_01||21. Датський стандарт продукції v_1_01</Label>
	<StartDate>2021-05-07</StartDate>
	<EndDate>2031-05-07</EndDate>
	<Language>da</Language>
	<MultiApproval>false</MultiApproval>
	<FastNavigation>false</FastNavigation>
	<Review>false</Review>
	<Summary>false</Summary>
	<DisplayOrder>0</DisplayOrder>
	<ElementList>
		<Element type=""DataElement"">
			<Id>142381</Id>
			<Label>21. DANISH Produktstandard v_1_01|21. DANISH Product standard v_1_01||21. Датський стандарт продукції v_1_01</Label>
			<Description>
				<![CDATA[Egenkontrolprogram for besætninger, der er certificeret under DANISH Produktstandard.<br>|<br>Self-inspection program for herds certified under DANISH Product Standard.||<br>Програма самоконтролю для стад, сертифікованих відповідно до датського стандарту продукції.]]>
			</Description>
			<DisplayOrder>0</DisplayOrder>
			<ReviewEnabled>false</ReviewEnabled>
			<ManualSync>false</ManualSync>
			<ExtraFieldsEnabled>false</ExtraFieldsEnabled>
			<DoneButtonDisabled>true</DoneButtonDisabled>
			<ApprovalEnabled>false</ApprovalEnabled>
			<DataItemGroupList>
				<DataItemGroup type=""FieldGroup"">
					<Id>373486</Id>
					<Label>LÆS MERE|READ MORE||ДОКЛАДНО</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>0</DisplayOrder>
					<Value>Closed</Value>
					<Color>fff6df</Color>
					<DataItemList>
						<DataItem type=""None"">
							<Id>373487</Id>
							<Label>INFO|INFO||ІНФОРМАЦІЯ</Label>
							<Description>
								<![CDATA[Egenkontrolprogrammet, der er en del af DANISH Produkt-standard, skal som minimum kontrolleres én gang årligt, og underskrives af den ansvarlige for besætningen, hvilket vil blive kontrolleret ved DANISH-besøg. Som vejledning til punkterne vedrørende dyrevelfærd, henvises til ""Vejledning om god dyrevelfærd i besætninger med grise"".<br>|<br>The self-inspection program, which is part of the DANISH Product Standard, must be inspected at least once a year and signed by the person in charge of the crew, which will be inspected during DANISH visits. For guidance on animal welfare items, please refer to ""Vejledning om god dyrevelfærd i besætninger med grise"".||<br>Програма самоконтролю, яка є частиною датського стандарту на продукцію, повинна перевірятися не рідше одного разу на рік і підписуватися особою, відповідальною за екіпаж, який буде перевірятися під час візитів до Данії. Для отримання рекомендацій з питань захисту тварин, будь ласка, зверніться до ""Vejledning om god dyrevelfærd i besætninger med grise""(""Керівництво по хорошому утриманню тварин в стадах свиней"").]]>
							</Description>
							<DisplayOrder>0</DisplayOrder>
							<Color>fff6df</Color>
						</DataItem>
					</DataItemList>
				</DataItemGroup>
			</DataItemGroupList>
			<DataItemList>
				<DataItem type=""CheckBox"">
					<Id>373488</Id>
					<Label>Branchekode for god produktionspraksis i primærproduktionen er udfyldt og underskrevet.|Industry code for good production practice in primary production is filled in and signed.||Галузевий кодекс належної виробничої практики в первинному виробництві заповнюється і підписується.</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>1</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>373490</Id>
					<Label>Der er dokumentation for alle udførte dyrlægebesøg. Besøgsrapporterne gemmes i to år.|There is documentation for all performed veterinary visits. The visit reports are stored for two years.||Є документація по всіх проведених ветеринарних візитів. Звіти про відвідування зберігаються протягом двох років.</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>2</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e2f4fb</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>373491</Id>
					<Label>Hvis der er indgået en sundheds-rådgivningsaftale, kan denne fremvises, og er der udfærdiget  handlingsplaner i relation til målrettet dyrevelfærdsindsats, kan disse også fremvises.|If a health advisory agreement has been entered into, this can be presented, and if action plans have been drawn up in relation to targeted animal welfare efforts, these can also be presented.||Якщо було укладено консультативну угоду з питань охорони здоров'я, це може бути представлено, і якщо були складені плани дій щодо цілеспрямованих зусиль щодо захисту тварин, вони також можуть бути представлені.</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>3</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>373492</Id>
					<Label>Alle dyr tilses mindst en gang dagligt.|All animals are inspected at least once a day.||Всіх тварин оглядають не рідше одного разу на день.</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>4</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e2f4fb</Color>
				</DataItem>
				<DataItem type=""None"">
					<Id>373493</Id>
					<Label>Her kontrolleres også at: |Here it is also checked that:||Тут також перевіряється, що:</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>5</DisplayOrder>
					<Color>e2f4fb</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>373494</Id>
					<Label>a. Alle dyr har vand og foder.|a. All animals have water and food.||a. у всіх тварин є вода і їжа.</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>6</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e2f4fb</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>373495</Id>
					<Label>b. Arealkravene er overholdt.|b. The area requirements have been complied with.||b. Вимоги до площі були дотримані.</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>7</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e2f4fb</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>373496</Id>
					<Label>c. Alle dyr kan rejse, lægge og hvile sig uden besvær.|c. All animals can get up, lie down and rest without difficulty.||c. Всі тварини можуть без праці вставати, лягати і відпочивати.</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>8</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e2f4fb</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>373497</Id>
					<Label>d. Gulvene ikke er glatte eller ujævne.|d. The floors are not slippery or uneven.||d. підлоги не слизькі і нерівні.</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>9</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e2f4fb</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>373498</Id>
					<Label>Alt automatiseret eller mekanisk udstyr efterses mindst én gang om dagen.|All automated or mechanical equipment is inspected at least once a day.||Все автоматизоване або механічне обладнання перевіряється не рідше одного разу на день.</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>10</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>373499</Id>
					<Label>Det sikres, at alle indgreb (kastration, halekupering, tandslibning og jernbehandling) foretages efter lovgivningen, og at der udvises fornøden omhu og hygiejne.|It is ensured that all procedures (castration, tail docking, tooth grinding and iron treatment) are carried out in accordance with the law, and that the necessary care and hygiene is exercised.||Забезпечується, щоб всі процедури (кастрація, стикування хвоста, шліфування зубів і обробка залізом) проводилися відповідно до закону, а також щоб дотримувався необхідний догляд і гігієна.</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>11</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e2f4fb</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>373500</Id>
					<Label>Fra 1. januar 2019 er alle halebid registreret.|From 1 January 2019, all tail bites are registered.||З 1 січня 2019 року реєструються всі укуси хвоста.</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>12</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>373501</Id>
					<Label>Fra 1. april 2019 foreligger der en opdateret risikovurdering og handlingsplan.|From 1 April 2019, there will be an updated risk assessment and action plan.||З 1 квітня 2019 року буде оновлено оцінку ризиків та план дій.</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>13</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e2f4fb</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>373502</Id>
					<Label>Fra 1. juli 2019 er der ved salg af halekuperede smågrise, både i Danmark og udland, indhentet dokumentation fra modtageren eller mellemhandleren om, at der er behov for at modtage halekuperede grise.|From 1 July 2019, when selling tail docking piglets, both in Denmark and abroad, documentation has been obtained from the recipient or middleman that there is a need to receive tail docking pigs.||З 1 липня 2019 року при продажу поросят для стикування хвостів, як в Данії, так і за кордоном, від одержувача або посередника була отримана документація про необхідність отримання свиней для стикування хвостів.</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>14</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>373503</Id>
					<Label>Der foreligger en målsætning med initiativer, der øger pattegrise-overlevelsen. Denne målsætning følges op årligt.|There is an objective with initiatives that increase piglet survival. This objective is followed up annually.||Існує мета з ініціативами, які підвищують виживання поросят. Ця мета виконується щорічно.</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>15</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e2f4fb</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>373504</Id>
					<Label>Syge, tilskadekomne og aggressive dyr bliver om nødvendigt isoleret, evt. flyttet til sygesti og evt. behandlet. Det sikres, at der er nok sygestier, og at disse er indrettet korrekt. Det sikres, at der føres ekstra tilsyn ved sammenblanding af dyr, for hurtigt at kunne gribe ind.|Sick, injured and aggressive animals are isolated if necessary moved to sick pen and treatment. It is ensured that there are enough sick pens and that these are arranged correctly. It is ensured that extra supervision is carried out when mixing animals, in order to be able to intervene quickly.||Хворих, травмованих і агресивних тварин ізолюють, при необхідності переміщують в хворий загін і проводять лікування. Необхідно переконатися, що є достатня кількість лікарняних ручок і що вони розташовані правильно. При змішуванні тварин забезпечується додатковий нагляд, щоб мати можливість швидко втрутитися.</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>16</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>373505</Id>
					<Label>Ved det daglige tilsyn kontrolleres, om der er tilfælde af halebid og/eller skuldersår. Eventuelle nye tilfælde sættes i behandling.|During the daily inspection, check whether there are cases of tail bites and / or shoulder ulcers. Any new cases are put into treatment.||При щоденному спостереженні перевіряйте, чи є випадки укусів за хвіст і / або поранень в плече. Будь-які нові справи приймаються до розгляду.</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>17</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e2f4fb</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>373506</Id>
					<Label>Der forefindes velfungerende boltpistol samt en skarp kniv til afblødning og/eller udstyr til rygmarvsstødning.|There is a well-functioning bolt gun as well as a sharp knife for de-bleeding and / or equipment for spinal cord impact.||Є добре функціонуючий болт-пістолет, а також гострий ніж для зупинки кровотечі та / або обладнання для впливу на спинний мозок.</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>18</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>373507</Id>
					<Label>Det overvåges, at alle grise har permanent adgang til en tilstrækkelig mængde halm eller andet manipulerbart materiale, der kan opfylde deres behov for beskæftigelses- og rodemateriale.|It is monitored that all pigs have permanent access to a sufficient amount of straw or other manipulable material that can meet their need for recreational material.||Контролюється, щоб усі свині мали постійний доступ до достатньої кількості соломи або іншого оброблюваного матеріалу, який може задовольнити їх потребу в рекреаційному матеріалі.</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>19</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e2f4fb</Color>
				</DataItem>
				<DataItem type=""CheckBox"">
					<Id>373489</Id>
					<Label>Det sikres, at det kun er transportegnede grise, der flyttes til udleverings-faciliteterne (udleveringsrummet). I tvivlstilfælde flyttes grisene til en særskilt sti, hvor vognmanden, eventuelt en dyrlæge, vurderer dyrenes transportegnethed. Der skal foreligge dokumentation fra dyrlægen om årlig gennemgang af faktaark fra SEGES om transportegnethed.|It is ensured that only transportable pigs are moved to the delivery facilities (delivery room). In case of doubt, the pigs are moved to a separate pen, where the haulier, possibly a veterinarian, assesses the animals' transportability. There must be documentation from the veterinarian about the annual review of fact sheets from SEGES on transport suitability.||Гарантується, що в приміщення для доставки (пологове відділення) переміщаються тільки транспортабельні свині. У разі сумнівів свиней переміщують в окремий загін, де перевізник, можливо, ветеринар, оцінює транспортабельність тварин. Повинна бути документація від ветеринара про щорічний огляд інформаційних бюлетенів SEGES про придатність для транспортування.</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>20</DisplayOrder>
					<Selected>false</Selected>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Picture"">
					<Id>373484</Id>
					<Label>Billede|Picture||Зображення</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>21</DisplayOrder>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Comment"">
					<Id>373483</Id>
					<Label>Kommentar|Comment||Коментар</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>22</DisplayOrder>
					<Multi>1</Multi>
					<GeolocationEnabled>false</GeolocationEnabled>
					<Split>false</Split>
					<Value/>
					<ReadOnly>false</ReadOnly>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""SaveButton"">
					<Id>373485</Id>
					<Label>Gem registrering|Save registration||Зберегти реєстрацію</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>23</DisplayOrder>
					<Value>GEM|SAVE||ЗБЕРЕГТИ</Value>
					<Color>f0f8db</Color>
				</DataItem>
			</DataItemList>
		</Element>
	</ElementList>
</Main>",
@"<?xml version=""1.0"" encoding=""UTF-8""?>
<Main>
	<Id>142212</Id>
	<Repeated>0</Repeated>
	<Label>22. Sigtetest|22. Sieve test||22. Випробування на сито</Label>
	<StartDate>2020-12-16</StartDate>
	<EndDate>2030-12-16</EndDate>
	<Language>da</Language>
	<MultiApproval>false</MultiApproval>
	<FastNavigation>false</FastNavigation>
	<Review>false</Review>
	<Summary>false</Summary>
	<DisplayOrder>0</DisplayOrder>
	<ElementList>
		<Element type=""DataElement"">
			<Id>142212</Id>
			<Label>22. Sigtetest|22. Sieve test||22. Випробування на сито</Label>
			<Description>
				<![CDATA[Tryk for at udføre sigtetest|Press to perform sieve test<br>||Натисніть для виконання тесту на сито<br>]]>
			</Description>
			<DisplayOrder>0</DisplayOrder>
			<ReviewEnabled>false</ReviewEnabled>
			<ManualSync>false</ManualSync>
			<ExtraFieldsEnabled>false</ExtraFieldsEnabled>
			<DoneButtonDisabled>true</DoneButtonDisabled>
			<ApprovalEnabled>false</ApprovalEnabled>
			<DataItemGroupList>
				<DataItemGroup type=""FieldGroup"">
					<Id>372712</Id>
					<Label>LÆS MERE|READ MORE||ДОКЛАДНО</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>0</DisplayOrder>
					<Value>Closed</Value>
					<Color>fff6df</Color>
					<DataItemList>
						<DataItem type=""None"">
							<Id>372713</Id>
							<Label>INFO|INFO||ІНФОРМАЦІЯ</Label>
							<Description>
								<![CDATA[Foderets partikelfordeling er et vigtigt område, da det påvirker både foderudnyttelsen og mave-/tarm-sundheden.<br><br>Indtast %. Skal summe til 100 %.<br>|<br>The feed particle distribution is an important area, as it affects both feed conversion and stomach / intestinal health.<br><br>Enter %. Must sum to 100 %.||<br>Розподіл частинок корму є важливою областю, оскільки воно впливає як на конверсію корму, так і на здоров'я шлунка/ кишечника.<br><br>введіть %. Сума повинна становити 100%.]]>
							</Description>
							<DisplayOrder>0</DisplayOrder>
							<Color>fff6df</Color>
						</DataItem>
					</DataItemList>
				</DataItemGroup>
			</DataItemGroupList>
			<DataItemList>
				<DataItem type=""Number"">
					<Id>372193</Id>
					<Label>Under 1 mm (%)|Less than 1 mm (%)||Менше 1 мм (%)</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>2</DisplayOrder>
					<Mandatory>false</Mandatory>
					<MinValue/>
					<MaxValue/>
					<Value/>
					<DecimalCount/>
					<UnitName/>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Number"">
					<Id>372194</Id>
					<Label>1-2 mm (%)|1-2 mm (%)||1-2 мм (%)</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>3</DisplayOrder>
					<Mandatory>false</Mandatory>
					<MinValue/>
					<MaxValue/>
					<Value/>
					<DecimalCount/>
					<UnitName/>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Number"">
					<Id>372195</Id>
					<Label>Over 2 mm (%)|More than 2 mm (%)||Більше 2 мм (%)</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>4</DisplayOrder>
					<Mandatory>false</Mandatory>
					<MinValue/>
					<MaxValue/>
					<Value/>
					<DecimalCount/>
					<UnitName/>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Picture"">
					<Id>372196</Id>
					<Label>Billede|Picture||Зображення</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>5</DisplayOrder>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Text"">
					<Id>372197</Id>
					<Label>Kommentar|Comment||Коментар</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>6</DisplayOrder>
					<Multi>0</Multi>
					<GeolocationEnabled>false</GeolocationEnabled>
					<Split>false</Split>
					<Value/>
					<ReadOnly>false</ReadOnly>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""SaveButton"">
					<Id>372192</Id>
					<Label>Gem registrering|Save registration||Зберегти реєстрацію</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>7</DisplayOrder>
					<Value>GEM|SAVE||ЗБЕРЕГТИ</Value>
					<Color>f0f8db</Color>
				</DataItem>
			</DataItemList>
		</Element>
	</ElementList>
</Main>",
@"<?xml version=""1.0"" encoding=""UTF-8""?>
<Main>
	<Id>142243</Id>
	<Repeated>0</Repeated>
	<Label>25. Markvandingsforbrug|25. Field irrigation consumption||25. Витрата на зрошення полів</Label>
	<StartDate>2021-01-11</StartDate>
	<EndDate>2031-01-11</EndDate>
	<Language>da</Language>
	<MultiApproval>false</MultiApproval>
	<FastNavigation>false</FastNavigation>
	<Review>false</Review>
	<Summary>false</Summary>
	<DisplayOrder>0</DisplayOrder>
	<ElementList>
		<Element type=""DataElement"">
			<Id>142243</Id>
			<Label>25. Markvandingsforbrug|25. Field irrigation consumption||25. Витрата на зрошення полів</Label>
			<Description>
				<![CDATA[Aflæs forbrug|Read consumption||Споживання читання]]>
			</Description>
			<DisplayOrder>0</DisplayOrder>
			<ReviewEnabled>false</ReviewEnabled>
			<ManualSync>false</ManualSync>
			<ExtraFieldsEnabled>false</ExtraFieldsEnabled>
			<DoneButtonDisabled>true</DoneButtonDisabled>
			<ApprovalEnabled>false</ApprovalEnabled>
			<DataItemGroupList>
				<DataItemGroup type=""FieldGroup"">
					<Id>372400</Id>
					<Label>LÆS MERE|READ MORE||ДОКЛАДНО</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>0</DisplayOrder>
					<Value>Closed</Value>
					<Color>fff6df</Color>
					<DataItemList>
						<DataItem type=""None"">
							<Id>372401</Id>
							<Label>INFO|INFO||ІНФОРМАЦІЯ</Label>
							<Description>
								<![CDATA[Aflæs Timetæller&nbsp;(timer) eller elmåler&nbsp;(kWh) eller vandmåler&nbsp;(m3)<br>|<br>Read Hour meter (hours) or electricity meter (kWh) or water meter (m3)||<br>Зчитування лічильника годин (годин) або лічильника електроенергії (кВт/год) або лічильника води (м3)]]>
							</Description>
							<DisplayOrder>0</DisplayOrder>
							<Color>fff6df</Color>
						</DataItem>
					</DataItemList>
				</DataItemGroup>
			</DataItemGroupList>
			<DataItemList>
				<DataItem type=""Number"">
					<Id>372402</Id>
					<Label>Timetæller (timer)|Hour meter (hours)||Лічильник годин (годин)</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>1</DisplayOrder>
					<Mandatory>false</Mandatory>
					<MinValue/>
					<MaxValue/>
					<Value/>
					<DecimalCount/>
					<UnitName/>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Number"">
					<Id>372403</Id>
					<Label>Elmåler (kWh)|Electricity meter (kWh)||Лічильник електроенергії (кВт/год)</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>2</DisplayOrder>
					<Mandatory>false</Mandatory>
					<MinValue/>
					<MaxValue/>
					<Value/>
					<DecimalCount/>
					<UnitName/>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Number"">
					<Id>372399</Id>
					<Label>Vandmåler (m3)|Water meter (m3)||Лічильник води (м3)</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>3</DisplayOrder>
					<Mandatory>false</Mandatory>
					<MinValue/>
					<MaxValue/>
					<Value/>
					<DecimalCount/>
					<UnitName/>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Picture"">
					<Id>372397</Id>
					<Label>Billede|Picture||Зображення</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>4</DisplayOrder>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""Comment"">
					<Id>372396</Id>
					<Label>Kommentar|Comment||Коментар</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>5</DisplayOrder>
					<Multi>1</Multi>
					<GeolocationEnabled>false</GeolocationEnabled>
					<Split>false</Split>
					<Value/>
					<ReadOnly>false</ReadOnly>
					<Mandatory>false</Mandatory>
					<Color>e8eaf6</Color>
				</DataItem>
				<DataItem type=""SaveButton"">
					<Id>372398</Id>
					<Label>Gem registrering|Save registration||Зберегти реєстрацію</Label>
					<Description>
						<![CDATA[]]>
					</Description>
					<DisplayOrder>6</DisplayOrder>
					<Value>GEM|SAVE||ЗБЕРЕГТИ</Value>
					<Color>f0f8db</Color>
				</DataItem>
			</DataItemList>
		</Element>
	</ElementList>
</Main>",
        };
    }
}
