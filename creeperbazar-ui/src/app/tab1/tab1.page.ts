import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-tab1',
  templateUrl: 'tab1.page.html',
  styleUrls: ['tab1.page.scss']
})
export class Tab1Page {

  public lobs = [ 
    {
      name: 'Property',
      icon: 'home', 
      desc: 'Property insurance provides protection against most risks to property, such as fire, theft and some weather damage.',
      iconColor: 'success'
    },
    {
      name: 'Health',
      icon: 'medkit', 
      desc: 'Health insurance is a type of insurance that covers the whole or a part of the risk of a person incurring medical expenses.',
      iconColor: 'danger'
    },
    {
      name: 'Casualty',
      icon: 'tv', 
      desc: 'Casualty insurance is a problematically defined term which broadly encompasses insurance not directly concerned with life insurance',
      iconColor: 'warning'
    },
    {
      name: 'Travel',
      icon: 'airplane', 
      desc: 'Travel insurance  is an insurance product for covering unforeseen losses incurred while travelling, either internationally or domestically.',
      iconColor: 'secondary'
    }
  ] ;

  constructor(public router:Router) {}


  cardClicked(lob) {
    console.log("Card clicked",lob);
    this.router.navigate(['tabs/tab2',lob]);
  }

}
