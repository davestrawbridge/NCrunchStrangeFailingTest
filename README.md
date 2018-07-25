# NCrunchStrangeFailingTest
Repro for a test that is marked as failed by NCrunch with message : This test was not executed during a planned execution run.  Ensure your test project is stable and does not contain issues in initialisation/teardown fixtures.

The bug is detailed here : 
http://forum.ncrunch.net/yaf_postsm10767_Tests-suddenly-start-failing-with-NCrunch-v3-9-0-1.aspx

## Another example

Remco's reply on the post above cites incompatibility with Autofixture as the problem - however I also have this problem with a test that doesn't use Autofixture.

_will try to reproduce the error with minimal test, then update the repo_

