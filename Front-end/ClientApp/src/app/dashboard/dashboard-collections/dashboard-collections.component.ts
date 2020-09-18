import { Component, OnInit } from '@angular/core';
import {MatDialog} from '@angular/material/dialog';

import {ActivatedRoute} from '@angular/router';
import { Collection } from 'src/app/models/Collection';

@Component({
  selector: 'app-dashboard-collections',
  templateUrl: './dashboard-collections.component.html',
  styleUrls: ['./dashboard-collections.component.css']
})
export class DashboardCollectionsComponent implements OnInit {

  collections: Array<Collection> = [];

  constructor(private dialog: MatDialog,
    private route: ActivatedRoute) { }

  ngOnInit() {
    this.route.data.subscribe(
      (data: Collection) => {
        this.collections = data['cltn_listing'];
      }
    );
  }


}
