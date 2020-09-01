import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-catalog-sidenav',
  templateUrl: './catalog-sidenav.component.html',
  styleUrls: ['./catalog-sidenav.component.css']
})
export class CatalogSidenavComponent implements OnInit {

  panelOpenState = false;

  constructor() { }


  ngOnInit() {
  }

}
