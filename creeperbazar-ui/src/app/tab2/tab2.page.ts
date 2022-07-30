import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-tab2',
  templateUrl: 'tab2.page.html',
  styleUrls: ['tab2.page.scss']
})
export class Tab2Page {

  activatedLob ;

 healthQuestions = [
    {
      id: 1,
      value: "Existing Illiness",
      isChecked :false
    },
    {
      id: 2,
      value : "Covid-19",
      isChecked :false
    },
    {
      id: 3,
      value : "Smoker",
      isChecked :false
    },
    {
      id : 4,
      value : "None of these",
      isChecked :false
    }
  ];
  propertQuestions = [    
      {
        id: 1,
        value: "Is your property 1000 feets of fire station",
        isChecked :false
      },
      {
        id: 2,
        value : "Have you had any property insurence claims",
        isChecked :false
      },
      {
        id: 3,
        value : "Is the property purchased recently",
        isChecked :false
      }     
    
  ];

  constructor(public router:Router, public activiatedRoute: ActivatedRoute) {
    console.log("loading tab2");
    this.activiatedRoute.params.subscribe(params => {
      this.activatedLob = params ;
      console.log(" back to home", params);
      if ( JSON.stringify(params) == '{}' ) {
        console.log("going back to home");
        // this.router.navigate(['tabs/tab1']);
      }
    });
  }
  cardClicked(lob) {
    console.log("Card clicked",lob);
    this.router.navigate(['tabs/tab3']);
  }

}
