import { Component, Input, OnInit } from '@angular/core';
import { Brand } from 'src/app/models/brand';
import { Collection } from 'src/app/models/Collection';



@Component({
  selector: 'app-catalog-sidenav',
  templateUrl: './catalog-sidenav.component.html',
  styleUrls: ['./catalog-sidenav.component.css']
})
export class CatalogSidenavComponent implements OnInit {

  brandPanelOpenState = false;
  collectionPanelOpenState = false;
  @Input() brands: Array<Brand>;
  @Input() collections: Array<Collection>

  allComplete: boolean = false;



  constructor() { }


  ngOnInit() {

  }



}

