import { TestBed } from '@angular/core/testing';

import { MyCubeServeTestService } from './my-cube-serve-test.service';

describe('MyCubeServeTestService', () => {
  let service: MyCubeServeTestService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(MyCubeServeTestService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
