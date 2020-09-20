import { Component, Input, OnInit, ViewChild, EventEmitter, Output } from '@angular/core';
import { Brand } from 'src/app/models/brand';
import { Collection } from 'src/app/models/Collection';
import {MatList, MatListOption} from '@angular/material/list';
import {SelectionModel} from '@angular/cdk/collections';


@Component({
  selector: 'app-catalog-sidenav',
  templateUrl: './catalog-sidenav.component.html',
  styleUrls: ['./catalog-sidenav.component.css']
})
export class CatalogSidenavComponent implements OnInit {

  brandPanelOpenState = false;
  collectionPanelOpenState = false;
  visibility= 'native';

  @Output() selectedCollectionOptions: EventEmitter<any[]> = new EventEmitter<MatListOption[]>();
  @Output() selectedBrandOptions: EventEmitter<any[]> = new EventEmitter<MatListOption[]>();


  @Input() brands: Array<Brand>;
  @Input() collections: Array<Collection>;


  allComplete: boolean = false;



  constructor() { }


  ngOnInit() {

  }

  onCollectionSelectionChange(selected: SelectionModel<any>[]){
      this.selectedCollectionOptions.emit(selected);
  }

  onBrandsSelectionChange(selected: SelectionModel<any>[]){
    this.selectedBrandOptions.emit(selected);
  }


}

