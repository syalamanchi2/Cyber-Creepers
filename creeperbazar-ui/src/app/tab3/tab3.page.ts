import { Component } from '@angular/core';

@Component({
  selector: 'app-tab3',
  templateUrl: 'tab3.page.html',
  styleUrls: ['tab3.page.scss']
})
export class Tab3Page {

  public quotes = [
    {
      logo: 'assets/HDFC.png',
      title: 'HDFC Insurance',
      subTitle : 'Sabse bada sach',
      annualPremium: '7000',
      monthlyPremium: '600',
      additional: [
        'Extra data 1', 
        'Extra data 2'
      ]
    },
    {
      logo: 'assets/ICICI.png',
      title: 'ICICI Insurance',
      subTitle : 'Nihaaye Vaade',
      annualPremium: '10000',
      monthlyPremium: '900',
      additional: [
        'Extra data 1', 
        'Extra data 2'
      ]
    },
    {
      logo: 'assets/LIC.png',
      title: 'LIC Insurance',
      subTitle : 'Ab bada Socho',
      annualPremium: '8000',
      monthlyPremium: '890',
      additional: [
        'Extra data 1', 
        'Extra data 2'
      ]
    }


  ] ;

  constructor() {}

}
